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
                            taskListTitle.Text = $"Задачі на {DateTime.Today.ToString("D")}";
                            break;
                        case 1:
                            DateTime startOfWeek;
                            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                                startOfWeek = DateTime.Today.AddDays(-6);
                            else
                                startOfWeek = DateTime.Today.AddDays(
                                (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
                                (int)DateTime.Today.DayOfWeek);                                    
                            if (task.Date >= startOfWeek && task.Date < startOfWeek.AddDays(7))
                                FillTaskList(task, index);

                            taskListTitle.Text = $"Задачі на тиждень з " +
                                $"{startOfWeek.ToString("D")} " +
                                $"по {startOfWeek.AddDays(7).ToString("D")}";
                            break;
                        case 2:
                            DateTime today = DateTime.Today;
                            if (task.Date.Year == today.Year && task.Date.Month == today.Month)
                                FillTaskList(task, index);

                            taskListTitle.Text = $"Задачі на {ToMonthName(task.Date)} " +
                                $"{task.Date.Year} р.";
                            break;
                        case 3:
                            monthCalendar.Enabled = true;
                            monthCalendar.BackColor = Color.White;
                            if (task.Date == monthCalendar.SelectionStart.Date)
                                FillTaskList(task, index);
                            taskListTitle.Text = $"Задачі на {task.Date}";
                            break;
                        case 4:
                            monthCalendar.Enabled = true;
                            monthCalendar.BackColor = Color.White;
                            DateTime startDate = monthCalendar.SelectionStart.Date;
                            DateTime endDate = monthCalendar.SelectionEnd.Date;
                            if (task.Date >= startDate && task.Date <= endDate)
                                FillTaskList(task, index);
                            taskListTitle.Text = $"Задачі на період з {startDate} " +
                                $"по {endDate}";
                            break;

                        default:
                            FillTaskList(task, index);
                            taskListTitle.Text = $"Задачі за весь період";
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
        private string ToMonthName(DateTime dt)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt.Month);
        }
        private void FillTaskList(ToDoTask task, int index)
        {
            if (projectList.GetItemChecked(index)
                &&
                ((inProgressCheck.Checked && task.IsDone == false) ||
                (finishedChek.Checked && task.IsDone == true))
                &&
                ((highPriorityCheck.Checked && task.PriorityId == 1) ||
                (normalPriorityCheck.Checked && task.PriorityId == 2) ||
                (lowPriorityCheck.Checked && task.PriorityId == 3))
                )
            {
                var current = tasksList.Items.Add(task.Name);
                current.SubItems.Add(task.Date.ToString("D"));
                current.SubItems.Add(task.Time.ToString("t"));
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
                commentTitle.Text = "Поточна задача: " + tasks[index].Name;
                ListViewItem currentTask = tasksList.Items[index];
                textAbout.Text = $"Назва: {tasks[index].Name}\n" +
                    $"Заплановано на: { currentTask.SubItems[1].Text}, " +
                    $"о { currentTask.SubItems[2].Text}\n" +
                    $"Пріорітет: { tasks[index].PriorityName}\n" +
                    $"Проект: { tasks[index].ProjectName}\n" +
                    $"Статус: { currentTask.SubItems[5].Text}\n" +
                    $"Коментар: { tasks[index].Comment}\n" +
                    $"Ключові слова: { tasks[index].Tags}\n";
            }
        }
        private void periodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthCalendar.Enabled)
            {
                monthCalendar.Enabled = false;
                monthCalendar.BackColor = Color.LightGray;
            }
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

        private void editTaskMenu_Click(object sender, EventArgs e)
        {
            TaskEditor taskEditor = new TaskEditor();
            taskEditor.OperationTitle = "Редагувння задачі";
            taskEditor.Projects = projects;
            taskEditor.Priorities = priorities;
            taskEditor.Tasks = tasks;
            ToDoTask editTask = tasks[tasksList.FocusedItem.Index];
            taskEditor.TaskName = editTask.Name;
            taskEditor.Date = editTask.Date;
            taskEditor.Time = editTask.Time;
            taskEditor.PriorityId = editTask.PriorityId;
            taskEditor.PriorityName = editTask.PriorityName;
            taskEditor.Tags = editTask.Tags;
            taskEditor.Comment = editTask.Comment;
            taskEditor.ProjectId = editTask.ProjectId;
            taskEditor.ProjectName = editTask.ProjectName;
            taskEditor.IsDone = editTask.IsDone;

            if (taskEditor.ShowDialog() == DialogResult.OK)
            {
                string query = "exec sp_UpdateTask @Id, @Name, @Date, @Time, @PriorityId, @Tag, @Comment, @ProjectId, @IsDone";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = editTask.Id;
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
                MessageBox.Show("Задача успішно змінена", "Сповіщення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProjects();
                LoadTasks();
            }
        }

        private void deleteTaskMenu_Click(object sender, EventArgs e)
        {
            TaskEditor taskEditor = new TaskEditor();
            taskEditor.OperationTitle = "Видалення задачі";
            taskEditor.Projects = projects;
            taskEditor.Priorities = priorities;
            taskEditor.Tasks = tasks;
            ToDoTask editTask = tasks[tasksList.FocusedItem.Index];
            taskEditor.TaskName = editTask.Name;
            taskEditor.Date = editTask.Date;
            taskEditor.Time = editTask.Time;
            taskEditor.PriorityId = editTask.PriorityId;
            taskEditor.PriorityName = editTask.PriorityName;
            taskEditor.Tags = editTask.Tags;
            taskEditor.Comment = editTask.Comment;
            taskEditor.ProjectId = editTask.ProjectId;
            taskEditor.ProjectName = editTask.ProjectName;
            taskEditor.IsDone = editTask.IsDone;

            if (taskEditor.ShowDialog() == DialogResult.OK)
            {
                string query = "exec sp_DeleteTask @Id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = editTask.Id;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Задача успішно видалена", "Сповіщення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProjects();
                LoadTasks();
            }
        }

        private void inProgressCheck_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void finishedChek_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void highPriorityCheck_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void normalPriorityCheck_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void lowPriorityCheck_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }
    }
}
