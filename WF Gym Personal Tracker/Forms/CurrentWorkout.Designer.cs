namespace WF_Gym_Personal_Tracker
{
    partial class CurrentWorkout
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
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            SuspendLayout();
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, -1);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(560, 36);
            menuBar1.TabIndex = 0;
            // 
            // CurrentWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(menuBar1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CurrentWorkout";
            Text = "CurrentWorkout";
            ResumeLayout(false);
        }

        #endregion

        private UI.MenuBar menuBar1;
    }
}