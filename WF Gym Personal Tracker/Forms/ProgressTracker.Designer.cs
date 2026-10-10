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
            lblBestSetCaption = new Label();
            lblSessionsCaption = new Label();
            lblTotalVolumeCaption = new Label();
            lblAverageRepsCaption = new Label();
            lblMaxRepsCaption = new Label();
            lblAverageReps = new Label();
            lblMaxReps = new Label();
            lblTotalVolume = new Label();
            lblSessions = new Label();
            lblBestSet = new Label();
            cmbWorkout = new ComboBox();
            cmbExercise = new ComboBox();
            lblWorkout = new Label();
            lblExercise = new Label();
            grpProgress = new GroupBox();
            grpRecords = new GroupBox();
            grpFrequency = new GroupBox();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            lblMaxWeightCaption = new Label();
            lblMaxWeight = new Label();
            grpStats.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpStats
            // 
            grpStats.Controls.Add(tableLayoutPanel1);
            grpStats.Location = new Point(493, 151);
            grpStats.Name = "grpStats";
            grpStats.Size = new Size(431, 471);
            grpStats.TabIndex = 1;
            grpStats.TabStop = false;
            grpStats.Text = "Exercise Statistics";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblMaxWeight, 1, 0);
            tableLayoutPanel1.Controls.Add(lblMaxWeightCaption, 0, 0);
            tableLayoutPanel1.Controls.Add(lblBestSetCaption, 0, 5);
            tableLayoutPanel1.Controls.Add(lblSessionsCaption, 0, 4);
            tableLayoutPanel1.Controls.Add(lblTotalVolumeCaption, 0, 3);
            tableLayoutPanel1.Controls.Add(lblAverageRepsCaption, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMaxRepsCaption, 0, 1);
            tableLayoutPanel1.Controls.Add(lblAverageReps, 1, 2);
            tableLayoutPanel1.Controls.Add(lblMaxReps, 1, 1);
            tableLayoutPanel1.Controls.Add(lblTotalVolume, 1, 3);
            tableLayoutPanel1.Controls.Add(lblSessions, 1, 4);
            tableLayoutPanel1.Controls.Add(lblBestSet, 1, 5);
            tableLayoutPanel1.Location = new Point(6, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Size = new Size(420, 427);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBestSetCaption
            // 
            lblBestSetCaption.AutoSize = true;
            lblBestSetCaption.Location = new Point(3, 362);
            lblBestSetCaption.Name = "lblBestSetCaption";
            lblBestSetCaption.Size = new Size(75, 25);
            lblBestSetCaption.TabIndex = 11;
            lblBestSetCaption.Text = "Best Set";
            // 
            // lblSessionsCaption
            // 
            lblSessionsCaption.AutoSize = true;
            lblSessionsCaption.Location = new Point(3, 296);
            lblSessionsCaption.Name = "lblSessionsCaption";
            lblSessionsCaption.Size = new Size(80, 25);
            lblSessionsCaption.TabIndex = 10;
            lblSessionsCaption.Text = "Sessions";
            // 
            // lblTotalVolumeCaption
            // 
            lblTotalVolumeCaption.AutoSize = true;
            lblTotalVolumeCaption.Location = new Point(3, 224);
            lblTotalVolumeCaption.Name = "lblTotalVolumeCaption";
            lblTotalVolumeCaption.Size = new Size(114, 25);
            lblTotalVolumeCaption.TabIndex = 9;
            lblTotalVolumeCaption.Text = "Total Volume";
            // 
            // lblAverageRepsCaption
            // 
            lblAverageRepsCaption.AutoSize = true;
            lblAverageRepsCaption.Location = new Point(3, 146);
            lblAverageRepsCaption.Name = "lblAverageRepsCaption";
            lblAverageRepsCaption.Size = new Size(120, 25);
            lblAverageRepsCaption.TabIndex = 8;
            lblAverageRepsCaption.Text = "Average Reps";
            // 
            // lblMaxRepsCaption
            // 
            lblMaxRepsCaption.AutoSize = true;
            lblMaxRepsCaption.Location = new Point(3, 73);
            lblMaxRepsCaption.Name = "lblMaxRepsCaption";
            lblMaxRepsCaption.Size = new Size(96, 25);
            lblMaxRepsCaption.TabIndex = 7;
            lblMaxRepsCaption.Text = "Most Reps";
            // 
            // lblAverageReps
            // 
            lblAverageReps.AutoSize = true;
            lblAverageReps.Location = new Point(213, 146);
            lblAverageReps.Name = "lblAverageReps";
            lblAverageReps.Size = new Size(120, 25);
            lblAverageReps.TabIndex = 2;
            lblAverageReps.Text = "Average Reps";
            // 
            // lblMaxReps
            // 
            lblMaxReps.AutoSize = true;
            lblMaxReps.Location = new Point(213, 73);
            lblMaxReps.Name = "lblMaxReps";
            lblMaxReps.Size = new Size(96, 25);
            lblMaxReps.TabIndex = 1;
            lblMaxReps.Text = "Most Reps";
            // 
            // lblTotalVolume
            // 
            lblTotalVolume.AutoSize = true;
            lblTotalVolume.Location = new Point(213, 224);
            lblTotalVolume.Name = "lblTotalVolume";
            lblTotalVolume.Size = new Size(114, 25);
            lblTotalVolume.TabIndex = 3;
            lblTotalVolume.Text = "Total Volume";
            // 
            // lblSessions
            // 
            lblSessions.AutoSize = true;
            lblSessions.Location = new Point(213, 296);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(80, 25);
            lblSessions.TabIndex = 4;
            lblSessions.Text = "Sessions";
            // 
            // lblBestSet
            // 
            lblBestSet.AutoSize = true;
            lblBestSet.Location = new Point(213, 362);
            lblBestSet.Name = "lblBestSet";
            lblBestSet.Size = new Size(75, 25);
            lblBestSet.TabIndex = 5;
            lblBestSet.Text = "Best Set";
            // 
            // cmbWorkout
            // 
            cmbWorkout.FormattingEnabled = true;
            cmbWorkout.Location = new Point(113, 92);
            cmbWorkout.Name = "cmbWorkout";
            cmbWorkout.Size = new Size(224, 33);
            cmbWorkout.TabIndex = 2;
            cmbWorkout.SelectedIndexChanged += cmbWorkout_SelectedIndexChanged;
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
            grpProgress.Location = new Point(26, 151);
            grpProgress.Name = "grpProgress";
            grpProgress.Size = new Size(461, 471);
            grpProgress.TabIndex = 6;
            grpProgress.TabStop = false;
            grpProgress.Text = "Progress over time";
            grpProgress.Enter += grpProgress_Enter;
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
            // lblMaxWeightCaption
            // 
            lblMaxWeightCaption.AutoSize = true;
            lblMaxWeightCaption.Location = new Point(3, 0);
            lblMaxWeightCaption.Name = "lblMaxWeightCaption";
            lblMaxWeightCaption.Size = new Size(140, 25);
            lblMaxWeightCaption.TabIndex = 12;
            lblMaxWeightCaption.Text = "Heaviest Weight";
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Location = new Point(213, 0);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(140, 25);
            lblMaxWeight.TabIndex = 13;
            lblMaxWeight.Text = "Heaviest Weight";
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
        private ComboBox cmbWorkout;
        private ComboBox cmbExercise;
        private Label lblWorkout;
        private Label lblExercise;
        private GroupBox grpProgress;
        private GroupBox grpRecords;
        private GroupBox grpFrequency;
        private UI.MenuBar menuBar1;
        private Label lblMaxReps;
        private Label lblAverageReps;
        private Label lblTotalVolume;
        private Label lblSessions;
        private Label lblBestSet;
        private Label lblAverageRepsCaption;
        private Label lblMaxRepsCaption;
        private Label lblBestSetCaption;
        private Label lblSessionsCaption;
        private Label lblTotalVolumeCaption;
        private Label lblMaxWeight;
        private Label lblMaxWeightCaption;
    }
}