namespace WF_Gym_Personal_Tracker.Forms
{
    partial class ActiveWorkout
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
            workoutName = new Label();
            progressBar1 = new ProgressBar();
            exerciseLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            weightBox = new TextBox();
            repsBox = new TextBox();
            setsBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, 1);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(804, 36);
            menuBar1.TabIndex = 0;
            // 
            // workoutName
            // 
            workoutName.AutoSize = true;
            workoutName.Location = new Point(353, 40);
            workoutName.Name = "workoutName";
            workoutName.Size = new Size(88, 15);
            workoutName.TabIndex = 1;
            workoutName.Text = "Workout Name";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(205, 254);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(370, 23);
            progressBar1.TabIndex = 2;
            // 
            // exerciseLabel
            // 
            exerciseLabel.AutoSize = true;
            exerciseLabel.Location = new Point(353, 82);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(91, 15);
            exerciseLabel.TabIndex = 3;
            exerciseLabel.Text = "Current Exercise";
            // 
            // button1
            // 
            button1.Location = new Point(205, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Previous Exercise";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 225);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Log";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(weightBox);
            panel1.Controls.Add(repsBox);
            panel1.Controls.Add(setsBox);
            panel1.Location = new Point(234, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 100);
            panel1.TabIndex = 6;
            // 
            // weightBox
            // 
            weightBox.Location = new Point(249, 51);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(61, 23);
            weightBox.TabIndex = 2;
            weightBox.TextChanged += weightBox_TextChanged;
            // 
            // repsBox
            // 
            repsBox.Location = new Point(133, 51);
            repsBox.Name = "repsBox";
            repsBox.Size = new Size(61, 23);
            repsBox.TabIndex = 1;
            repsBox.TextChanged += repsBox_TextChanged;
            // 
            // setsBox
            // 
            setsBox.Location = new Point(22, 51);
            setsBox.Name = "setsBox";
            setsBox.Size = new Size(61, 23);
            setsBox.TabIndex = 0;
            setsBox.TextChanged += setsBox_TextChanged;
            // 
            // ActiveWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(exerciseLabel);
            Controls.Add(progressBar1);
            Controls.Add(workoutName);
            Controls.Add(menuBar1);
            Name = "ActiveWorkout";
            Text = "ActiveWorkout";
            Load += ActiveWorkout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UI.MenuBar menuBar1;
        private Label workoutName;
        private ProgressBar progressBar1;
        private Label exerciseLabel;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private TextBox weightBox;
        private TextBox repsBox;
        private TextBox setsBox;
    }
}