namespace WF_Gym_Personal_Tracker
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeTxt = new Label();
            groupBox1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            DashBoardMenuItem = new ToolStripMenuItem();
            workoutBuilderMenuItem = new ToolStripMenuItem();
            progressTrackerMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            welcomeTxt.ForeColor = Color.FromArgb(64, 64, 64);
            welcomeTxt.Location = new Point(402, 25);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(99, 28);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "Welcome";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(323, 52);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(262, 122);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(342, 181);
            monthCalendar1.Margin = new Padding(6, 5, 6, 5);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(323, 340);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(253, 15);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 364);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "quote";
            // 
            // DashBoardMenuItem
            // 
            DashBoardMenuItem.Name = "DashBoardMenuItem";
            DashBoardMenuItem.Size = new Size(76, 22);
            DashBoardMenuItem.Text = "Dashboard";
            DashBoardMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // workoutBuilderMenuItem
            // 
            workoutBuilderMenuItem.Name = "workoutBuilderMenuItem";
            workoutBuilderMenuItem.Size = new Size(105, 22);
            workoutBuilderMenuItem.Text = "Workout Builder";
            workoutBuilderMenuItem.Click += workoutBuilderToolStripMenuItem_Click;
            // 
            // progressTrackerMenuItem
            // 
            progressTrackerMenuItem.Name = "progressTrackerMenuItem";
            progressTrackerMenuItem.Size = new Size(105, 22);
            progressTrackerMenuItem.Text = "Progress Tracker";
            progressTrackerMenuItem.Click += progressTrackerMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DashBoardMenuItem, workoutBuilderMenuItem, progressTrackerMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(783, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(welcomeTxt);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Form1";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTxt;
        private GroupBox groupBox1;
        private MonthCalendar monthCalendar1;
        private ProgressBar progressBar1;
        private Label label1;
        private ToolStripMenuItem DashBoardMenuItem;
        private ToolStripMenuItem workoutBuilderMenuItem;
        private ToolStripMenuItem progressTrackerMenuItem;
        private MenuStrip menuStrip1;
    }
}
