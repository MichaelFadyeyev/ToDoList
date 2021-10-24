
namespace ToDoList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printTaskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.findTaskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.projectManagerMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.textComment = new System.Windows.Forms.TextBox();
            this.tasksList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priorityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lowPriorityCheck = new System.Windows.Forms.CheckBox();
            this.finishedChek = new System.Windows.Forms.CheckBox();
            this.normalPriorityCheck = new System.Windows.Forms.CheckBox();
            this.inProgressCheck = new System.Windows.Forms.CheckBox();
            this.highPriorityCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.periodSelect = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectList = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.tasksMenuI,
            this.projectsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printTaskListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(40, 20);
            this.fileMenu.Text = "&File";
            // 
            // printTaskListToolStripMenuItem
            // 
            this.printTaskListToolStripMenuItem.Name = "printTaskListToolStripMenuItem";
            this.printTaskListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.printTaskListToolStripMenuItem.Text = "&PrintTaskList";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // tasksMenuI
            // 
            this.tasksMenuI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskMenu,
            this.editTaskMenu,
            this.deleteTaskMenu,
            this.findTaskMenu});
            this.tasksMenuI.Name = "tasksMenuI";
            this.tasksMenuI.Size = new System.Drawing.Size(53, 20);
            this.tasksMenuI.Text = "&Tasks";
            // 
            // addTaskMenu
            // 
            this.addTaskMenu.Name = "addTaskMenu";
            this.addTaskMenu.Size = new System.Drawing.Size(180, 22);
            this.addTaskMenu.Text = "&AddTask";
            this.addTaskMenu.Click += new System.EventHandler(this.addTaskMenu_Click);
            // 
            // editTaskMenu
            // 
            this.editTaskMenu.Name = "editTaskMenu";
            this.editTaskMenu.Size = new System.Drawing.Size(180, 22);
            this.editTaskMenu.Text = "&EditTask";
            this.editTaskMenu.Click += new System.EventHandler(this.editTaskMenu_Click);
            // 
            // deleteTaskMenu
            // 
            this.deleteTaskMenu.Name = "deleteTaskMenu";
            this.deleteTaskMenu.Size = new System.Drawing.Size(180, 22);
            this.deleteTaskMenu.Text = "&DeleteTask";
            this.deleteTaskMenu.Click += new System.EventHandler(this.deleteTaskMenu_Click);
            // 
            // findTaskMenu
            // 
            this.findTaskMenu.Name = "findTaskMenu";
            this.findTaskMenu.Size = new System.Drawing.Size(180, 22);
            this.findTaskMenu.Text = "&FindTask";
            // 
            // projectsMenu
            // 
            this.projectsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectManagerMenuI});
            this.projectsMenu.Name = "projectsMenu";
            this.projectsMenu.Size = new System.Drawing.Size(66, 20);
            this.projectsMenu.Text = "&Projects";
            // 
            // projectManagerMenuI
            // 
            this.projectManagerMenuI.Name = "projectManagerMenuI";
            this.projectManagerMenuI.Size = new System.Drawing.Size(166, 22);
            this.projectManagerMenuI.Text = "&ProjectManager";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentLabel);
            this.groupBox2.Controls.Add(this.textComment);
            this.groupBox2.Controls.Add(this.tasksList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 403);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задачі";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(7, 283);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(69, 16);
            this.commentLabel.TabIndex = 8;
            this.commentLabel.Text = "Коментар:";
            // 
            // textComment
            // 
            this.textComment.BackColor = System.Drawing.SystemColors.Window;
            this.textComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textComment.Location = new System.Drawing.Point(3, 302);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(929, 98);
            this.textComment.TabIndex = 7;
            // 
            // tasksList
            // 
            this.tasksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.dateColumn,
            this.timeColumn,
            this.priorityColumn,
            this.projectColumn,
            this.statusColumn});
            this.tasksList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksList.FullRowSelect = true;
            this.tasksList.HideSelection = false;
            this.tasksList.Location = new System.Drawing.Point(3, 19);
            this.tasksList.Name = "tasksList";
            this.tasksList.Size = new System.Drawing.Size(929, 245);
            this.tasksList.TabIndex = 6;
            this.tasksList.UseCompatibleStateImageBehavior = false;
            this.tasksList.View = System.Windows.Forms.View.Details;
            this.tasksList.SelectedIndexChanged += new System.EventHandler(this.tasksList_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Задача";
            this.nameColumn.Width = 275;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Дата";
            this.dateColumn.Width = 110;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Час";
            this.timeColumn.Width = 88;
            // 
            // priorityColumn
            // 
            this.priorityColumn.Text = "Пріорітет";
            this.priorityColumn.Width = 106;
            // 
            // projectColumn
            // 
            this.projectColumn.Text = "Проект";
            this.projectColumn.Width = 257;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Статус";
            this.statusColumn.Width = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lowPriorityCheck);
            this.groupBox1.Controls.Add(this.finishedChek);
            this.groupBox1.Controls.Add(this.normalPriorityCheck);
            this.groupBox1.Controls.Add(this.inProgressCheck);
            this.groupBox1.Controls.Add(this.highPriorityCheck);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.periodSelect);
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.projectList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(935, 251);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lowPriorityCheck
            // 
            this.lowPriorityCheck.AutoSize = true;
            this.lowPriorityCheck.Location = new System.Drawing.Point(406, 91);
            this.lowPriorityCheck.Name = "lowPriorityCheck";
            this.lowPriorityCheck.Size = new System.Drawing.Size(75, 20);
            this.lowPriorityCheck.TabIndex = 12;
            this.lowPriorityCheck.Text = "Низький";
            this.lowPriorityCheck.UseVisualStyleBackColor = true;
            // 
            // finishedChek
            // 
            this.finishedChek.AutoSize = true;
            this.finishedChek.Location = new System.Drawing.Point(406, 211);
            this.finishedChek.Name = "finishedChek";
            this.finishedChek.Size = new System.Drawing.Size(89, 20);
            this.finishedChek.TabIndex = 12;
            this.finishedChek.Text = "Завершені";
            this.finishedChek.UseVisualStyleBackColor = true;
            // 
            // normalPriorityCheck
            // 
            this.normalPriorityCheck.AutoSize = true;
            this.normalPriorityCheck.Location = new System.Drawing.Point(406, 65);
            this.normalPriorityCheck.Name = "normalPriorityCheck";
            this.normalPriorityCheck.Size = new System.Drawing.Size(80, 20);
            this.normalPriorityCheck.TabIndex = 12;
            this.normalPriorityCheck.Text = "Середній";
            this.normalPriorityCheck.UseVisualStyleBackColor = true;
            // 
            // inProgressCheck
            // 
            this.inProgressCheck.AutoSize = true;
            this.inProgressCheck.Location = new System.Drawing.Point(406, 185);
            this.inProgressCheck.Name = "inProgressCheck";
            this.inProgressCheck.Size = new System.Drawing.Size(103, 20);
            this.inProgressCheck.TabIndex = 12;
            this.inProgressCheck.Text = "Незавершені";
            this.inProgressCheck.UseVisualStyleBackColor = true;
            // 
            // highPriorityCheck
            // 
            this.highPriorityCheck.AutoSize = true;
            this.highPriorityCheck.Location = new System.Drawing.Point(406, 39);
            this.highPriorityCheck.Name = "highPriorityCheck";
            this.highPriorityCheck.Size = new System.Drawing.Size(74, 20);
            this.highPriorityCheck.TabIndex = 12;
            this.highPriorityCheck.Text = "Високий";
            this.highPriorityCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пріорітет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Проекти:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Період показу:";
            // 
            // periodSelect
            // 
            this.periodSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodSelect.FormattingEnabled = true;
            this.periodSelect.Items.AddRange(new object[] {
            "на сьогодні",
            "на тиждень",
            "на місяць",
            "на дату",
            "на період",
            "всі справи"});
            this.periodSelect.Location = new System.Drawing.Point(156, 39);
            this.periodSelect.Name = "periodSelect";
            this.periodSelect.Size = new System.Drawing.Size(164, 24);
            this.periodSelect.TabIndex = 9;
            this.periodSelect.SelectedIndexChanged += new System.EventHandler(this.periodSelect_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(156, 75);
            this.monthCalendar.MaxSelectionCount = 365;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // projectList
            // 
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(687, 39);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(236, 202);
            this.projectList.TabIndex = 5;
            this.projectList.SelectedIndexChanged += new System.EventHandler(this.projectList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ToDo Organizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem printTaskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksMenuI;
        private System.Windows.Forms.ToolStripMenuItem addTaskMenu;
        private System.Windows.Forms.ToolStripMenuItem editTaskMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskMenu;
        private System.Windows.Forms.ToolStripMenuItem findTaskMenu;
        private System.Windows.Forms.ToolStripMenuItem projectsMenu;
        private System.Windows.Forms.ToolStripMenuItem projectManagerMenuI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.ListView tasksList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ColumnHeader projectColumn;
        private System.Windows.Forms.ColumnHeader priorityColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox projectList;
        private System.Windows.Forms.ComboBox periodSelect;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.CheckBox lowPriorityCheck;
        private System.Windows.Forms.CheckBox finishedChek;
        private System.Windows.Forms.CheckBox normalPriorityCheck;
        private System.Windows.Forms.CheckBox inProgressCheck;
        private System.Windows.Forms.CheckBox highPriorityCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

