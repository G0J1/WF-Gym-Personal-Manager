namespace WF_Gym_Personal_Tracker
{
    partial class ProgressTracker
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
            grpStats = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMaxWeightCaption = new Label();
            cmbWorkout = new ComboBox();
            cmbExercise = new ComboBox();
            lblWorkout = new Label();
            lblExercise = new Label();
            grpProgress = new GroupBox();
            grpRecords = new GroupBox();
            grpFrequency = new GroupBox();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            grpStats.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpStats
            // 
            grpStats.Controls.Add(tableLayoutPanel1);
            grpStats.Location = new Point(493, 160);
            grpStats.Name = "grpStats";
            grpStats.Size = new Size(431, 462);
            grpStats.TabIndex = 1;
            grpStats.TabStop = false;
            grpStats.Text = "Exercise Statistics";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblMaxWeightCaption, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(420, 427);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaxWeightCaption
            // 
            lblMaxWeightCaption.AutoSize = true;
            lblMaxWeightCaption.Dock = DockStyle.Fill;
            lblMaxWeightCaption.Location = new Point(4, 0);
            lblMaxWeightCaption.Margin = new Padding(4, 0, 4, 0);
            lblMaxWeightCaption.Name = "lblMaxWeightCaption";
            lblMaxWeightCaption.Size = new Size(202, 81);
            lblMaxWeightCaption.TabIndex = 0;
            lblMaxWeightCaption.Text = "Heaviest Weight\r\n";
            lblMaxWeightCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbWorkout
            // 
            cmbWorkout.FormattingEnabled = true;
            cmbWorkout.Location = new Point(113, 92);
            cmbWorkout.Name = "cmbWorkout";
            cmbWorkout.Size = new Size(224, 33);
            cmbWorkout.TabIndex = 2;
            // 
            // cmbExercise
            // 
            cmbExercise.FormattingEnabled = true;
            cmbExercise.Location = new Point(571, 92);
            cmbExercise.Name = "cmbExercise";
            cmbExercise.Size = new Size(224, 33);
            cmbExercise.TabIndex = 3;
            cmbExercise.SelectedIndexChanged += cmbExercise_SelectedIndexChanged;
            // 
            // lblWorkout
            // 
            lblWorkout.AutoSize = true;
            lblWorkout.Location = new Point(26, 95);
            lblWorkout.Name = "lblWorkout";
            lblWorkout.Size = new Size(81, 25);
            lblWorkout.TabIndex = 4;
            lblWorkout.Text = "Workout";
            // 
            // lblExercise
            // 
            lblExercise.AutoSize = true;
            lblExercise.Location = new Point(493, 95);
            lblExercise.Name = "lblExercise";
            lblExercise.Size = new Size(73, 25);
            lblExercise.TabIndex = 5;
            lblExercise.Text = "Exercise";
            // 
            // grpProgress
            // 
            grpProgress.Location = new Point(26, 170);
            grpProgress.Name = "grpProgress";
            grpProgress.Size = new Size(461, 452);
            grpProgress.TabIndex = 6;
            grpProgress.TabStop = false;
            grpProgress.Text = "Progress over time";
            // 
            // grpRecords
            // 
            grpRecords.Location = new Point(493, 622);
            grpRecords.Name = "grpRecords";
            grpRecords.Size = new Size(431, 233);
            grpRecords.TabIndex = 7;
            grpRecords.TabStop = false;
            grpRecords.Text = "Recent personal records";
            // 
            // grpFrequency
            // 
            grpFrequency.Location = new Point(16, 622);
            grpFrequency.Name = "grpFrequency";
            grpFrequency.Size = new Size(470, 233);
            grpFrequency.TabIndex = 8;
            grpFrequency.TabStop = false;
            grpFrequency.Text = "Workouts per week (last 4 weeks)";
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, 0);
            menuBar1.Margin = new Padding(6, 8, 6, 8);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(943, 60);
            menuBar1.TabIndex = 9;
            // 
            // ProgressTracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 915);
            Controls.Add(menuBar1);
            Controls.Add(grpFrequency);
            Controls.Add(grpRecords);
            Controls.Add(grpProgress);
            Controls.Add(lblExercise);
            Controls.Add(lblWorkout);
            Controls.Add(cmbExercise);
            Controls.Add(cmbWorkout);
            Controls.Add(grpStats);
            Name = "ProgressTracker";
            Text = "ProgressTracker";
            grpStats.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpStats;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMaxWeightCaption;
        private ComboBox cmbWorkout;
        private ComboBox cmbExercise;
        private Label lblWorkout;
        private Label lblExercise;
        private GroupBox grpProgress;
        private GroupBox grpRecords;
        private GroupBox grpFrequency;
        private UI.MenuBar menuBar1;
    }
}