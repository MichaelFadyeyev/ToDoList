using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Models
{
    public partial class TaskEditor : Form
    {
        public string OperationTitle { get; set; }
        public string TaskName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int PriorityId { get; set; }
        public string PriorityName { get; set; }
        public string Tags { get; set; }
        public string Comment { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public bool IsDone { get; set; }
        public List<Project> Projects { get; set; }
        public List<Priority> Priorities { get; set; }
        public List<ToDoTask> Tasks { get; set; }



        public TaskEditor()
        {
            InitializeComponent();
        }

        private void TaskEditor_Load(object sender, EventArgs e)
        {
            title.Text = OperationTitle;
            foreach (var project in Projects)
            {
                projectList.Items.Add(project.Name);
            }

            foreach (var priority in Priorities)
            {
                priorityList.Items.Add(priority.Name);
            }

            dateSet.Value = Date;
            timeSet.Format = DateTimePickerFormat.Time;
            timeSet.CustomFormat = "HH:MM";
            timeSet.ShowUpDown = true;
            timeSet.Value = Time;
            // Видалення задачі
            if (OperationTitle != "Нова задача")
            {
                taskField.Text = TaskName;
                priorityList.SelectedIndex = priorityList.FindStringExact(PriorityName);
                projectList.SelectedIndex = projectList.FindStringExact(ProjectName);
                tagsField.Text = Tags;
                commentField.Text = Comment;
                isDoneCheck.Checked = IsDone;
                if (OperationTitle == "Видалення задачі")
                {
                    taskField.Enabled = false;
                    dateSet.Enabled = false;
                    timeSet.Enabled = false;
                    priorityList.Enabled = false;
                    projectList.Enabled = false;
                    tagsField.Enabled = false;
                    commentField.Enabled = false;
                    isDoneCheck.Enabled = false;
                }
            }
            else
            {
                projectList.SelectedIndex = 0;
                priorityList.SelectedIndex = 1;
            }

        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            int counterOkResult = 0;
            if (String.IsNullOrEmpty(taskField.Text))
                MessageBox.Show("Введіть назву задачі", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (OperationTitle == "Нова задача" &&
               Tasks.Find(t => t.Name == taskField.Text) != null &&
               Tasks.Find(t => t.Date == dateSet.Value) != null &&
               Tasks.Find(t => t.Time == timeSet.Value) != null)
            {
                MessageBox.Show("Задача вже запланована на даний час", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TaskName = taskField.Text;
                Date = dateSet.Value;
                Time = timeSet.Value;
                Tags = tagsField.Text;
                Comment = commentField.Text;
                IsDone = isDoneCheck.Checked;
                counterOkResult++;
            }

            if (String.IsNullOrEmpty(tagsField.Text))
                Tags = "";
            else
                Tags = tagsField.Text;

            if (String.IsNullOrEmpty(commentField.Text))
                Comment = "";
            else
                Comment = commentField.Text;

            if (dateSet.Value < DateTime.Today)
                MessageBox.Show("Введіть коректну дату початку для задачі", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                Date = dateSet.Value;
                counterOkResult++;
            }


            if (timeSet.Value < DateTime.Now)
                MessageBox.Show("Введіть коректний час початку для задачі", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Time = timeSet.Value;
                counterOkResult++;
            }

            ProjectId = Projects.Find(p => p.Name == (string)projectList.SelectedItem).Id;
            PriorityId = Priorities.Find(p => p.Name == (string)priorityList.SelectedItem).Id;
            if (counterOkResult == 3)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
