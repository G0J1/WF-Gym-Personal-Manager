namespace WF_Gym_Personal_Tracker.UI
{
    partial class MenuBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            workoutBuilderToolStripMenuItem = new ToolStripMenuItem();
            progressTrackerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, workoutBuilderToolStripMenuItem, progressTrackerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(437, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 20);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // workoutBuilderToolStripMenuItem
            // 
            workoutBuilderToolStripMenuItem.Name = "workoutBuilderToolStripMenuItem";
            workoutBuilderToolStripMenuItem.Size = new Size(105, 20);
            workoutBuilderToolStripMenuItem.Text = "Workout Builder";
            workoutBuilderToolStripMenuItem.Click += workoutBuilderToolStripMenuItem_Click;
            // 
            // progressTrackerToolStripMenuItem
            // 
            progressTrackerToolStripMenuItem.Name = "progressTrackerToolStripMenuItem";
            progressTrackerToolStripMenuItem.Size = new Size(105, 20);
            progressTrackerToolStripMenuItem.Text = "Progress Tracker";
            progressTrackerToolStripMenuItem.Click += progressTrackerToolStripMenuItem_Click;
            // 
            // MenuBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Name = "MenuBar";
            Size = new Size(437, 36);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem workoutBuilderToolStripMenuItem;
        private ToolStripMenuItem progressTrackerToolStripMenuItem;
    }
}
