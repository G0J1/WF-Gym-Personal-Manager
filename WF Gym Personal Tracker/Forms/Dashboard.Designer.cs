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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            workoutBuilderToolStripMenuItem = new ToolStripMenuItem();
            progressTrackerToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            welcomeTxt.ForeColor = Color.FromArgb(64, 64, 64);
            welcomeTxt.Location = new Point(575, 42);
            welcomeTxt.Margin = new Padding(4, 0, 4, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(147, 41);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "Welcome";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, workoutBuilderToolStripMenuItem, progressTrackerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1119, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(116, 29);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // workoutBuilderToolStripMenuItem
            // 
            workoutBuilderToolStripMenuItem.Name = "workoutBuilderToolStripMenuItem";
            workoutBuilderToolStripMenuItem.Size = new Size(156, 29);
            workoutBuilderToolStripMenuItem.Text = "Workout Builder";
            workoutBuilderToolStripMenuItem.Click += workoutBuilderToolStripMenuItem_Click;
            // 
            // progressTrackerToolStripMenuItem
            // 
            progressTrackerToolStripMenuItem.Name = "progressTrackerToolStripMenuItem";
            progressTrackerToolStripMenuItem.Size = new Size(156, 29);
            progressTrackerToolStripMenuItem.Text = "Progress Tracker";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(462, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 203);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(489, 301);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(462, 566);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(362, 25);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 606);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "quote";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 750);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(welcomeTxt);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem workoutBuilderToolStripMenuItem;
        private ToolStripMenuItem progressTrackerToolStripMenuItem;
        private GroupBox groupBox1;
        private MonthCalendar monthCalendar1;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
