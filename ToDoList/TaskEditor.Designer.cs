
namespace ToDoList.Models
{
    partial class TaskEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectList = new System.Windows.Forms.ComboBox();
            this.isDoneCheck = new System.Windows.Forms.CheckBox();
            this.timeSet = new System.Windows.Forms.DateTimePicker();
            this.dateSet = new System.Windows.Forms.DateTimePicker();
            this.commentField = new System.Windows.Forms.TextBox();
            this.taskField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tagsField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priorityList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // projectList
            // 
            this.projectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(44, 258);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(220, 24);
            this.projectList.TabIndex = 21;
            // 
            // isDoneCheck
            // 
            this.isDoneCheck.AutoSize = true;
            this.isDoneCheck.Location = new System.Drawing.Point(44, 546);
            this.isDoneCheck.Name = "isDoneCheck";
            this.isDoneCheck.Size = new System.Drawing.Size(169, 20);
            this.isDoneCheck.TabIndex = 20;
            this.isDoneCheck.Text = "Позначити, як виконане";
            this.isDoneCheck.UseVisualStyleBackColor = true;
            // 
            // timeSet
            // 
            this.timeSet.Location = new System.Drawing.Point(208, 140);
            this.timeSet.Name = "timeSet";
            this.timeSet.ShowUpDown = true;
            this.timeSet.Size = new System.Drawing.Size(56, 23);
            this.timeSet.TabIndex = 17;
            // 
            // dateSet
            // 
            this.dateSet.Location = new System.Drawing.Point(44, 140);
            this.dateSet.Name = "dateSet";
            this.dateSet.Size = new System.Drawing.Size(158, 23);
            this.dateSet.TabIndex = 18;
            // 
            // commentField
            // 
            this.commentField.Location = new System.Drawing.Point(44, 398);
            this.commentField.Multiline = true;
            this.commentField.Name = "commentField";
            this.commentField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentField.Size = new System.Drawing.Size(220, 138);
            this.commentField.TabIndex = 15;
            // 
            // taskField
            // 
            this.taskField.Location = new System.Drawing.Point(44, 83);
            this.taskField.Name = "taskField";
            this.taskField.Size = new System.Drawing.Size(220, 23);
            this.taskField.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата і час виконання:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Коментарі:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Назва проекту:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Назва задачі";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(83, 589);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(125, 27);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Застосувати";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(41, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(29, 16);
            this.title.TabIndex = 9;
            this.title.Text = "title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ключові слова:";
            // 
            // tagsField
            // 
            this.tagsField.Location = new System.Drawing.Point(44, 320);
            this.tagsField.Multiline = true;
            this.tagsField.Name = "tagsField";
            this.tagsField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagsField.Size = new System.Drawing.Size(220, 46);
            this.tagsField.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Пріорітет:";
            // 
            // priorityList
            // 
            this.priorityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityList.FormattingEnabled = true;
            this.priorityList.Location = new System.Drawing.Point(44, 197);
            this.priorityList.Name = "priorityList";
            this.priorityList.Size = new System.Drawing.Size(220, 24);
            this.priorityList.TabIndex = 21;
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 641);
            this.Controls.Add(this.priorityList);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.isDoneCheck);
            this.Controls.Add(this.timeSet);
            this.Controls.Add(this.dateSet);
            this.Controls.Add(this.tagsField);
            this.Controls.Add(this.commentField);
            this.Controls.Add(this.taskField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskEditor";
            this.Text = "Редактор задач";
            this.Load += new System.EventHandler(this.TaskEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectList;
        private System.Windows.Forms.CheckBox isDoneCheck;
        private System.Windows.Forms.DateTimePicker timeSet;
        private System.Windows.Forms.DateTimePicker dateSet;
        private System.Windows.Forms.TextBox commentField;
        private System.Windows.Forms.TextBox taskField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagsField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox priorityList;
    }
}