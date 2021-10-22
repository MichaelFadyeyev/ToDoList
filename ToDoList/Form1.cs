using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using ToDoList.Models;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        List<ToDoTask> tasks;
        List<Project> projects;
        List<Priority> priorities;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            tasks = new List<ToDoTask>();
            projects = new List<Project>();
            priorities = new List<Priority>();
            LoadProjects();
            periodSelect.SelectedIndex = 0;
            LoadTasks();
            LoadPriority();
        }

        private void LoadProjects()
        {
            try
            {
                string query = "EXEC sp_SelectProjects";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                projectList.Items.Clear();
                projects.Clear();
                int counter = 0;
                while (reader.Read())
                {
                    Project project = new Project()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };
                    projectList.Items.Add(project);
                    projectList.SetItemChecked(counter, true);
                    counter++;
                    projects.Add(project);
                }
                projectList.CheckOnClick = true;
                projectList.DisplayMember = "Name";
                projectList.ValueMember = "Id";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Помилка завантаження проектів",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void LoadTasks()
        {
            try
            {
                string query = "exec sp_SelectTasks";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                tasksList.Items.Clear();
                tasks.Clear();
                while (reader.Read())
                {
                    ToDoTask task = new ToDoTask()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Date = (DateTime)reader["Date"],
                        Time = DateTime.Parse(reader["Time"].ToString(), System.Globalization.CultureInfo.CurrentCulture),
                        PriorityId = (int)reader["PriorityId"],
                        PriorityName = reader["PriorityName"].ToString(),
                        Tags = reader["Tag"].ToString(),
                        Comment = reader["Comment"].ToString(),
                        ProjectId = (int)reader["ProjectId"],
                        ProjectName = reader["ProjectName"].ToString(),
                        IsDone = (bool)reader["IsDone"]
                    };
                    int index = task.ProjectId - 1;

                    switch (periodSelect.SelectedIndex)
                    {
                        case 0:
                            if (task.Date == DateTime.Today)
                                FillTaskList(task, index);
                            break;
                        case 1:
                            DateTime startOfWeek = DateTime.Today.AddDays(
                                (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek-
                                (int)DateTime.Today.DayOfWeek);
                            if (task.Date >= startOfWeek && task.Date < startOfWeek.AddDays(7))
                                FillTaskList(task, index);
                            break;
                        case 2:
                            DateTime today = DateTime.Today;
                            if (task.Date.Year == today.Year && task.Date.Month == today.Month)
                            {
                                FillTaskList(task, index);
                            }
                            break;
                        case 3:
                            dateTime.Visible = true;
                            if (task.Date == monthCalendar.SelectionStart.Date)
                                FillTaskList(task, index);
                            break;
                        case 4:
                            DateTime startDate = monthCalendar.SelectionStart.Date;
                            DateTime endDate = monthCalendar.SelectionEnd.Date;
                            if (task.Date >= startDate && task.Date <= endDate)
                                FillTaskList(task, index);
                            break;

                        default:
                            FillTaskList(task, index);
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Помилка завантаження задач",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void FillTaskList(ToDoTask task, int index)
        {
            if (projectList.GetItemChecked(index))
            {
                var current = tasksList.Items.Add(task.Name);
                current.SubItems.Add(task.Date.ToString("D"));
                current.SubItems.Add(task.Time.ToString("HH:MM"));
                current.SubItems.Add(task.PriorityName);
                current.SubItems.Add(task.ProjectName);
                if (task.IsDone)
                    current.SubItems.Add("Завершена");
                else
                    current.SubItems.Add("Незавершена");
                tasks.Add(task);
            }
        }
        private void LoadPriority()
        {
            try
            {
                string query = "EXEC sp_SelectPriority";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                priorities.Clear();

                while (reader.Read())
                {
                    Priority priority = new Priority()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };
                    priorities.Add(priority);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Помилка завантаження списку пріорітетів",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void projectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void tasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksList.FocusedItem != null)
            {
                int index = tasksList.FocusedItem.Index;
                textComment.Text = tasks[index].Comment;
            }
        }

        private void periodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateTime.Visible)
            {
                dateTime.Visible = false;
            }
            LoadTasks();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (periodSelect.SelectedIndex==3 || periodSelect.SelectedIndex == 4)
            {
                LoadTasks();
            }

        }

        private void addTaskMenu_Click(object sender, EventArgs e)
        {
            TaskEditor taskEditor = new TaskEditor();
            taskEditor.OperationTitle = "Нова задача";
            taskEditor.Projects = projects;
            taskEditor.Priorities = priorities;
            //taskEditor.ProjectsName = tasksList.FocusedItem.SubItems[1].Text;
            taskEditor.Tasks = tasks;
            taskEditor.Date = DateTime.Now;
            taskEditor.Time = DateTime.Now;
            if (taskEditor.ShowDialog() == DialogResult.OK)
            {
                string query = "exec sp_AddTask @Name, @Date, @Time, @PriorityId, @Tag, @Comment, @ProjectId, @IsDone";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = taskEditor.TaskName;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = taskEditor.Date;
                cmd.Parameters.Add("@Time", SqlDbType.Time).Value = taskEditor.Time.TimeOfDay;
                cmd.Parameters.Add("@PriorityId", SqlDbType.Int).Value = taskEditor.PriorityId;
                cmd.Parameters.Add("@Tag", SqlDbType.NVarChar).Value = taskEditor.Tags;
                cmd.Parameters.Add("@Comment", SqlDbType.NVarChar).Value = taskEditor.Comment;
                cmd.Parameters.Add("@ProjectId", SqlDbType.Int).Value = taskEditor.ProjectId;
                cmd.Parameters.Add("@IsDone", SqlDbType.Bit).Value = taskEditor.IsDone;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Задача успішно додана", "Сповіщення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProjects();
                LoadTasks();
            }
        }
    }
}
