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
            strengthPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            weightBox = new TextBox();
            repsBox = new TextBox();
            setsBox = new TextBox();
            timeBasedPanel = new Panel();
            label4 = new Label();
            toggleTimerBtn = new Button();
            timeLbl = new Label();
            strengthPanel.SuspendLayout();
            timeBasedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, 2);
            menuBar1.Margin = new Padding(6, 8, 6, 8);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(1149, 60);
            menuBar1.TabIndex = 0;
            // 
            // workoutName
            // 
            workoutName.AutoSize = true;
            workoutName.Location = new Point(504, 67);
            workoutName.Margin = new Padding(4, 0, 4, 0);
            workoutName.Name = "workoutName";
            workoutName.Size = new Size(133, 25);
            workoutName.TabIndex = 1;
            workoutName.Text = "Workout Name";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(293, 423);
            progressBar1.Margin = new Padding(4, 5, 4, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(529, 38);
            progressBar1.TabIndex = 2;
            // 
            // exerciseLabel
            // 
            exerciseLabel.AutoSize = true;
            exerciseLabel.Location = new Point(504, 137);
            exerciseLabel.Margin = new Padding(4, 0, 4, 0);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(136, 25);
            exerciseLabel.TabIndex = 3;
            exerciseLabel.Text = "Current Exercise";
            // 
            // button1
            // 
            button1.Location = new Point(293, 375);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 4;
            button1.Text = "Previous Exercise";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(714, 375);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 5;
            button2.Text = "Log";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // strengthPanel
            // 
            strengthPanel.Controls.Add(label3);
            strengthPanel.Controls.Add(label2);
            strengthPanel.Controls.Add(label1);
            strengthPanel.Controls.Add(weightBox);
            strengthPanel.Controls.Add(repsBox);
            strengthPanel.Controls.Add(setsBox);
            strengthPanel.Location = new Point(334, 182);
            strengthPanel.Margin = new Padding(4, 5, 4, 5);
            strengthPanel.Name = "strengthPanel";
            strengthPanel.Size = new Size(487, 167);
            strengthPanel.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 5;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 4;
            label2.Text = "Reps";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 3;
            label1.Text = "Sets";
            // 
            // weightBox
            // 
            weightBox.Location = new Point(356, 85);
            weightBox.Margin = new Padding(4, 5, 4, 5);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(85, 31);
            weightBox.TabIndex = 2;
            weightBox.TextChanged += weightBox_TextChanged;
            // 
            // repsBox
            // 
            repsBox.Location = new Point(190, 85);
            repsBox.Margin = new Padding(4, 5, 4, 5);
            repsBox.Name = "repsBox";
            repsBox.Size = new Size(85, 31);
            repsBox.TabIndex = 1;
            repsBox.TextChanged += repsBox_TextChanged;
            // 
            // setsBox
            // 
            setsBox.Location = new Point(31, 85);
            setsBox.Margin = new Padding(4, 5, 4, 5);
            setsBox.Name = "setsBox";
            setsBox.Size = new Size(85, 31);
            setsBox.TabIndex = 0;
            setsBox.TextChanged += setsBox_TextChanged;
            // 
            // timeBasedPanel
            // 
            timeBasedPanel.Controls.Add(timeLbl);
            timeBasedPanel.Controls.Add(toggleTimerBtn);
            timeBasedPanel.Controls.Add(label4);
            timeBasedPanel.Location = new Point(334, 179);
            timeBasedPanel.Name = "timeBasedPanel";
            timeBasedPanel.Size = new Size(487, 167);
            timeBasedPanel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 3);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 0;
            label4.Text = "Timer";
            // 
            // toggleTimerBtn
            // 
            toggleTimerBtn.Location = new Point(181, 88);
            toggleTimerBtn.Name = "toggleTimerBtn";
            toggleTimerBtn.Size = new Size(112, 34);
            toggleTimerBtn.TabIndex = 1;
            toggleTimerBtn.Text = "Start";
            toggleTimerBtn.UseVisualStyleBackColor = true;
            toggleTimerBtn.Click += toggleTimerBtn_Click;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(212, 44);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(47, 25);
            timeLbl.TabIndex = 2;
            timeLbl.Text = "time";
            // 
            // ActiveWorkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(timeBasedPanel);
            Controls.Add(strengthPanel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(exerciseLabel);
            Controls.Add(progressBar1);
            Controls.Add(workoutName);
            Controls.Add(menuBar1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ActiveWorkout";
            Text = "ActiveWorkout";
            Load += ActiveWorkout_Load;
            strengthPanel.ResumeLayout(false);
            strengthPanel.PerformLayout();
            timeBasedPanel.ResumeLayout(false);
            timeBasedPanel.PerformLayout();
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
        private Panel strengthPanel;
        private TextBox weightBox;
        private TextBox repsBox;
        private TextBox setsBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel timeBasedPanel;
        private Button toggleTimerBtn;
        private Label label4;
        private Label timeLbl;
    }
}