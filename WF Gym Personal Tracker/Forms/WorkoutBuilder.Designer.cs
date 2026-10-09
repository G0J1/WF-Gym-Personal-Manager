namespace WF_Gym_Personal_Tracker
{
    partial class WorkoutBuilder
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(209, 41);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 37);
            button1.TabIndex = 0;
            button1.Text = "Arm Day";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(209, 95);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 1;
            button2.Text = "Leg Day";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(209, 152);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(116, 38);
            button3.TabIndex = 2;
            button3.Text = "Full Body";
            button3.UseVisualStyleBackColor = true;
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(-1, 0);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(562, 36);
            menuBar1.TabIndex = 3;
            // 
            // WorkoutBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 209);
            Controls.Add(menuBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WorkoutBuilder";
            Text = "WorkoutBuilder";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private UI.MenuBar menuBar1;
    }
}