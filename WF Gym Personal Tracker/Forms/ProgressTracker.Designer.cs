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
            grpStats.Location = new Point(345, 96);
            grpStats.Margin = new Padding(2, 2, 2, 2);
            grpStats.Name = "grpStats";
            grpStats.Padding = new Padding(2, 2, 2, 2);
            grpStats.Size = new Size(302, 277);
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
            tableLayoutPanel1.Location = new Point(4, 18);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(294, 256);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaxWeightCaption
            // 
            lblMaxWeightCaption.AutoSize = true;
            lblMaxWeightCaption.Dock = DockStyle.Fill;
            lblMaxWeightCaption.Location = new Point(3, 0);
            lblMaxWeightCaption.Name = "lblMaxWeightCaption";
            lblMaxWeightCaption.Size = new Size(141, 48);
            lblMaxWeightCaption.TabIndex = 0;
            lblMaxWeightCaption.Text = "Heaviest Weight\r\n";
            lblMaxWeightCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbWorkout
            // 
            cmbWorkout.FormattingEnabled = true;
            cmbWorkout.Location = new Point(79, 55);
            cmbWorkout.Margin = new Padding(2, 2, 2, 2);
            cmbWorkout.Name = "cmbWorkout";
            cmbWorkout.Size = new Size(158, 23);
            cmbWorkout.TabIndex = 2;
            // 
            // cmbExercise
            // 
            cmbExercise.FormattingEnabled = true;
            cmbExercise.Location = new Point(400, 55);
            cmbExercise.Margin = new Padding(2, 2, 2, 2);
            cmbExercise.Name = "cmbExercise";
            cmbExercise.Size = new Size(158, 23);
            cmbExercise.TabIndex = 3;
            // 
            // lblWorkout
            // 
            lblWorkout.AutoSize = true;
            lblWorkout.Location = new Point(18, 57);
            lblWorkout.Margin = new Padding(2, 0, 2, 0);
            lblWorkout.Name = "lblWorkout";
            lblWorkout.Size = new Size(53, 15);
            lblWorkout.TabIndex = 4;
            lblWorkout.Text = "Workout";
            // 
            // lblExercise
            // 
            lblExercise.AutoSize = true;
            lblExercise.Location = new Point(345, 57);
            lblExercise.Margin = new Padding(2, 0, 2, 0);
            lblExercise.Name = "lblExercise";
            lblExercise.Size = new Size(48, 15);
            lblExercise.TabIndex = 5;
            lblExercise.Text = "Exercise";
            // 
            // grpProgress
            // 
            grpProgress.Location = new Point(18, 102);
            grpProgress.Margin = new Padding(2, 2, 2, 2);
            grpProgress.Name = "grpProgress";
            grpProgress.Padding = new Padding(2, 2, 2, 2);
            grpProgress.Size = new Size(323, 271);
            grpProgress.TabIndex = 6;
            grpProgress.TabStop = false;
            grpProgress.Text = "Progress over time";
            // 
            // grpRecords
            // 
            grpRecords.Location = new Point(345, 373);
            grpRecords.Margin = new Padding(2, 2, 2, 2);
            grpRecords.Name = "grpRecords";
            grpRecords.Padding = new Padding(2, 2, 2, 2);
            grpRecords.Size = new Size(302, 140);
            grpRecords.TabIndex = 7;
            grpRecords.TabStop = false;
            grpRecords.Text = "Recent personal records";
            // 
            // grpFrequency
            // 
            grpFrequency.Location = new Point(11, 373);
            grpFrequency.Margin = new Padding(2, 2, 2, 2);
            grpFrequency.Name = "grpFrequency";
            grpFrequency.Padding = new Padding(2, 2, 2, 2);
            grpFrequency.Size = new Size(329, 140);
            grpFrequency.TabIndex = 8;
            grpFrequency.TabStop = false;
            grpFrequency.Text = "Workouts per week (last 4 weeks)";
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, 0);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(660, 36);
            menuBar1.TabIndex = 9;
            // 
            // ProgressTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 549);
            Controls.Add(menuBar1);
            Controls.Add(grpFrequency);
            Controls.Add(grpRecords);
            Controls.Add(grpProgress);
            Controls.Add(lblExercise);
            Controls.Add(lblWorkout);
            Controls.Add(cmbExercise);
            Controls.Add(cmbWorkout);
            Controls.Add(grpStats);
            Margin = new Padding(2, 2, 2, 2);
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