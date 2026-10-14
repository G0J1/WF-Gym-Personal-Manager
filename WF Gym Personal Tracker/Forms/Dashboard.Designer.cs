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
            components = new System.ComponentModel.Container();
            welcomeTxt = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            nextBtn = new Button();
            previousBtn = new Button();
            button3 = new Button();
            todaysWorkoutTable = new DataGridView();
            ExerciseName = new DataGridViewTextBoxColumn();
            Sets = new DataGridViewTextBoxColumn();
            Reps = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            Completed = new DataGridViewCheckBoxColumn();
            WorkoutNameLabel = new Label();
            groupBox1 = new GroupBox();
            workoutLogBindingSource = new BindingSource(components);
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)todaysWorkoutTable).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workoutLogBindingSource).BeginInit();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            welcomeTxt.ForeColor = Color.FromArgb(64, 64, 64);
            welcomeTxt.Location = new Point(575, 48);
            welcomeTxt.Margin = new Padding(4, 0, 4, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(147, 41);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "Welcome";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(438, 706);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(361, 25);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 734);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "quote";
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(-1, -2);
            menuBar1.Margin = new Padding(6, 8, 6, 8);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(1297, 60);
            menuBar1.TabIndex = 6;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(1126, 383);
            nextBtn.Margin = new Padding(4, 5, 4, 5);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(107, 38);
            nextBtn.TabIndex = 7;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += button1_Click;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(42, 383);
            previousBtn.Margin = new Padding(4, 5, 4, 5);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(107, 38);
            previousBtn.TabIndex = 8;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(557, 610);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(143, 57);
            button3.TabIndex = 9;
            button3.Text = "Start Workout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // todaysWorkoutTable
            // 
            todaysWorkoutTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todaysWorkoutTable.Columns.AddRange(new DataGridViewColumn[] { ExerciseName, Sets, Reps, Weight, Duration, Completed });
            todaysWorkoutTable.Location = new Point(7, 92);
            todaysWorkoutTable.Margin = new Padding(4, 5, 4, 5);
            todaysWorkoutTable.Name = "todaysWorkoutTable";
            todaysWorkoutTable.ReadOnly = true;
            todaysWorkoutTable.RowHeadersWidth = 62;
            todaysWorkoutTable.Size = new Size(919, 272);
            todaysWorkoutTable.TabIndex = 0;
            // 
            // ExerciseName
            // 
            ExerciseName.DataPropertyName = "name";
            ExerciseName.HeaderText = "Exercise Name";
            ExerciseName.MinimumWidth = 8;
            ExerciseName.Name = "ExerciseName";
            ExerciseName.ReadOnly = true;
            ExerciseName.Width = 150;
            // 
            // Sets
            // 
            Sets.DataPropertyName = "sets";
            Sets.HeaderText = "Sets";
            Sets.MinimumWidth = 8;
            Sets.Name = "Sets";
            Sets.ReadOnly = true;
            Sets.Width = 150;
            // 
            // Reps
            // 
            Reps.DataPropertyName = "reps";
            Reps.HeaderText = "Reps";
            Reps.MinimumWidth = 8;
            Reps.Name = "Reps";
            Reps.ReadOnly = true;
            Reps.Width = 150;
            // 
            // Weight
            // 
            Weight.DataPropertyName = "weight";
            Weight.HeaderText = "Weight";
            Weight.MinimumWidth = 8;
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            Weight.Width = 150;
            // 
            // Duration
            // 
            Duration.DataPropertyName = "duration";
            Duration.HeaderText = "Duration";
            Duration.MinimumWidth = 8;
            Duration.Name = "Duration";
            Duration.ReadOnly = true;
            Duration.Width = 150;
            // 
            // Completed
            // 
            Completed.DataPropertyName = "completed";
            Completed.HeaderText = "Completed";
            Completed.MinimumWidth = 8;
            Completed.Name = "Completed";
            Completed.ReadOnly = true;
            Completed.Resizable = DataGridViewTriState.True;
            Completed.SortMode = DataGridViewColumnSortMode.Automatic;
            Completed.Width = 150;
            // 
            // WorkoutNameLabel
            // 
            WorkoutNameLabel.AutoSize = true;
            WorkoutNameLabel.Location = new Point(394, 45);
            WorkoutNameLabel.Margin = new Padding(4, 0, 4, 0);
            WorkoutNameLabel.Name = "WorkoutNameLabel";
            WorkoutNameLabel.Size = new Size(133, 25);
            WorkoutNameLabel.TabIndex = 2;
            WorkoutNameLabel.Text = "Workout Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WorkoutNameLabel);
            groupBox1.Controls.Add(todaysWorkoutTable);
            groupBox1.Location = new Point(169, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(940, 448);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Today's Workout";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(609, 106);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(59, 25);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "label2";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 1043);
            Controls.Add(dateLabel);
            Controls.Add(button3);
            Controls.Add(previousBtn);
            Controls.Add(nextBtn);
            Controls.Add(menuBar1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(welcomeTxt);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)todaysWorkoutTable).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workoutLogBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTxt;
        private ProgressBar progressBar1;
        private Label label1;
        private UI.MenuBar menuBar1;
        private Button nextBtn;
        private Button previousBtn;
        private Button button3;
        private DataGridView todaysWorkoutTable;
        private Label WorkoutNameLabel;
        private GroupBox groupBox1;
        private BindingSource workoutLogBindingSource;
        private DataGridViewTextBoxColumn ExerciseName;
        private DataGridViewTextBoxColumn Sets;
        private DataGridViewTextBoxColumn Reps;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewCheckBoxColumn Completed;
        private Label dateLabel;
    }
}
