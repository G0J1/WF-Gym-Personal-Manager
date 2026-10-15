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
            lblMaxWeight = new Label();
            lblMaxWeightCaption = new Label();
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
            progressGraph = new ScottPlot.WinForms.FormsPlot();
            grpRecords = new GroupBox();
            recordsList = new ListBox();
            grpFrequency = new GroupBox();
            frequencyGraph = new ScottPlot.WinForms.FormsPlot();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            grpStats.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpProgress.SuspendLayout();
            grpRecords.SuspendLayout();
            grpFrequency.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // grpStats
            // 
            grpStats.Controls.Add(tableLayoutPanel1);
            grpStats.Location = new Point(572, 70);
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Size = new Size(425, 441);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Location = new Point(215, 0);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(140, 25);
            lblMaxWeight.TabIndex = 13;
            lblMaxWeight.Text = "Heaviest Weight";
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
            // lblBestSetCaption
            // 
            lblBestSetCaption.AutoSize = true;
            lblBestSetCaption.Location = new Point(3, 376);
            lblBestSetCaption.Name = "lblBestSetCaption";
            lblBestSetCaption.Size = new Size(75, 25);
            lblBestSetCaption.TabIndex = 11;
            lblBestSetCaption.Text = "Best Set";
            // 
            // lblSessionsCaption
            // 
            lblSessionsCaption.AutoSize = true;
            lblSessionsCaption.Location = new Point(3, 310);
            lblSessionsCaption.Name = "lblSessionsCaption";
            lblSessionsCaption.Size = new Size(80, 25);
            lblSessionsCaption.TabIndex = 10;
            lblSessionsCaption.Text = "Sessions";
            // 
            // lblTotalVolumeCaption
            // 
            lblTotalVolumeCaption.AutoSize = true;
            lblTotalVolumeCaption.Location = new Point(3, 238);
            lblTotalVolumeCaption.Name = "lblTotalVolumeCaption";
            lblTotalVolumeCaption.Size = new Size(114, 25);
            lblTotalVolumeCaption.TabIndex = 9;
            lblTotalVolumeCaption.Text = "Total Volume";
            // 
            // lblAverageRepsCaption
            // 
            lblAverageRepsCaption.AutoSize = true;
            lblAverageRepsCaption.Location = new Point(3, 160);
            lblAverageRepsCaption.Name = "lblAverageRepsCaption";
            lblAverageRepsCaption.Size = new Size(120, 25);
            lblAverageRepsCaption.TabIndex = 8;
            lblAverageRepsCaption.Text = "Average Reps";
            // 
            // lblMaxRepsCaption
            // 
            lblMaxRepsCaption.AutoSize = true;
            lblMaxRepsCaption.Location = new Point(3, 80);
            lblMaxRepsCaption.Name = "lblMaxRepsCaption";
            lblMaxRepsCaption.Size = new Size(96, 25);
            lblMaxRepsCaption.TabIndex = 7;
            lblMaxRepsCaption.Text = "Most Reps";
            // 
            // lblAverageReps
            // 
            lblAverageReps.AutoSize = true;
            lblAverageReps.Location = new Point(215, 160);
            lblAverageReps.Name = "lblAverageReps";
            lblAverageReps.Size = new Size(120, 25);
            lblAverageReps.TabIndex = 2;
            lblAverageReps.Text = "Average Reps";
            // 
            // lblMaxReps
            // 
            lblMaxReps.AutoSize = true;
            lblMaxReps.Location = new Point(215, 80);
            lblMaxReps.Name = "lblMaxReps";
            lblMaxReps.Size = new Size(96, 25);
            lblMaxReps.TabIndex = 1;
            lblMaxReps.Text = "Most Reps";
            // 
            // lblTotalVolume
            // 
            lblTotalVolume.AutoSize = true;
            lblTotalVolume.Location = new Point(215, 238);
            lblTotalVolume.Name = "lblTotalVolume";
            lblTotalVolume.Size = new Size(114, 25);
            lblTotalVolume.TabIndex = 3;
            lblTotalVolume.Text = "Total Volume";
            // 
            // lblSessions
            // 
            lblSessions.AutoSize = true;
            lblSessions.Location = new Point(215, 310);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(80, 25);
            lblSessions.TabIndex = 4;
            lblSessions.Text = "Sessions";
            // 
            // lblBestSet
            // 
            lblBestSet.AutoSize = true;
            lblBestSet.Location = new Point(215, 376);
            lblBestSet.Name = "lblBestSet";
            lblBestSet.Size = new Size(75, 25);
            lblBestSet.TabIndex = 5;
            lblBestSet.Text = "Best Set";
            // 
            // cmbWorkout
            // 
            cmbWorkout.FormattingEnabled = true;
            cmbWorkout.Location = new Point(163, 3);
            cmbWorkout.Name = "cmbWorkout";
            cmbWorkout.Size = new Size(224, 33);
            cmbWorkout.TabIndex = 2;
            cmbWorkout.SelectedIndexChanged += cmbWorkout_SelectedIndexChanged;
            // 
            // cmbExercise
            // 
            cmbExercise.FormattingEnabled = true;
            cmbExercise.Location = new Point(162, 3);
            cmbExercise.Name = "cmbExercise";
            cmbExercise.Size = new Size(224, 33);
            cmbExercise.TabIndex = 3;
            cmbExercise.SelectedIndexChanged += cmbExercise_SelectedIndexChanged;
            // 
            // lblWorkout
            // 
            lblWorkout.AutoSize = true;
            lblWorkout.Location = new Point(3, 0);
            lblWorkout.Name = "lblWorkout";
            lblWorkout.Size = new Size(81, 25);
            lblWorkout.TabIndex = 4;
            lblWorkout.Text = "Workout";
            // 
            // lblExercise
            // 
            lblExercise.AutoSize = true;
            lblExercise.Location = new Point(3, 0);
            lblExercise.Name = "lblExercise";
            lblExercise.Size = new Size(73, 25);
            lblExercise.TabIndex = 5;
            lblExercise.Text = "Exercise";
            // 
            // grpProgress
            // 
            grpProgress.Controls.Add(progressGraph);
            grpProgress.Location = new Point(3, 70);
            grpProgress.Name = "grpProgress";
            grpProgress.Size = new Size(471, 471);
            grpProgress.TabIndex = 6;
            grpProgress.TabStop = false;
            grpProgress.Text = "Progress over time";
            grpProgress.Enter += grpProgress_Enter;
            // 
            // progressGraph
            // 
            progressGraph.Dock = DockStyle.Fill;
            progressGraph.Location = new Point(3, 27);
            progressGraph.Name = "progressGraph";
            progressGraph.Size = new Size(465, 441);
            progressGraph.TabIndex = 0;
            // 
            // grpRecords
            // 
            grpRecords.Controls.Add(recordsList);
            grpRecords.Location = new Point(572, 648);
            grpRecords.Name = "grpRecords";
            grpRecords.Size = new Size(431, 233);
            grpRecords.TabIndex = 7;
            grpRecords.TabStop = false;
            grpRecords.Text = "Recent personal records";
            // 
            // recordsList
            // 
            recordsList.Dock = DockStyle.Fill;
            recordsList.FormattingEnabled = true;
            recordsList.Location = new Point(3, 27);
            recordsList.Name = "recordsList";
            recordsList.Size = new Size(425, 203);
            recordsList.TabIndex = 0;
            // 
            // grpFrequency
            // 
            grpFrequency.Controls.Add(frequencyGraph);
            grpFrequency.Location = new Point(3, 648);
            grpFrequency.Name = "grpFrequency";
            grpFrequency.Size = new Size(470, 233);
            grpFrequency.TabIndex = 8;
            grpFrequency.TabStop = false;
            grpFrequency.Text = "Workouts per week (last 4 weeks)";
            // 
            // frequencyGraph
            // 
            frequencyGraph.Dock = DockStyle.Fill;
            frequencyGraph.Location = new Point(3, 27);
            frequencyGraph.Name = "frequencyGraph";
            frequencyGraph.Size = new Size(464, 203);
            frequencyGraph.TabIndex = 0;
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, 0);
            menuBar1.Margin = new Padding(6, 8, 6, 8);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(943, 60);
            menuBar1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(grpStats, 1, 1);
            tableLayoutPanel2.Controls.Add(grpProgress, 0, 1);
            tableLayoutPanel2.Controls.Add(grpFrequency, 0, 2);
            tableLayoutPanel2.Controls.Add(grpRecords, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.200987F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.86601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30.9330044F));
            tableLayoutPanel2.Size = new Size(1139, 935);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel4.Controls.Add(lblWorkout, 0, 0);
            tableLayoutPanel4.Controls.Add(cmbWorkout, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(563, 61);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.28283F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.71717F));
            tableLayoutPanel3.Controls.Add(cmbExercise, 1, 0);
            tableLayoutPanel3.Controls.Add(lblExercise, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(572, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(564, 61);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // ProgressTracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 935);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(menuBar1);
            Name = "ProgressTracker";
            Text = "ProgressTracker";
            grpStats.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            grpProgress.ResumeLayout(false);
            grpRecords.ResumeLayout(false);
            grpFrequency.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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
        private ListBox recordsList;
        private ScottPlot.WinForms.FormsPlot progressGraph;
        private ScottPlot.WinForms.FormsPlot frequencyGraph;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}