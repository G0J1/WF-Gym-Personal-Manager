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
            monthCalendar1 = new MonthCalendar();
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
            welcomeTxt.Location = new Point(402, 25);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(99, 28);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "Welcome";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(322, 368);
            monthCalendar1.Margin = new Padding(6, 5, 6, 5);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(303, 534);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(253, 15);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 551);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "quote";
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(-1, -1);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(908, 36);
            menuBar1.TabIndex = 6;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(784, 195);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 7;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += button1_Click;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(25, 195);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(75, 23);
            previousBtn.TabIndex = 8;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(390, 326);
            button3.Name = "button3";
            button3.Size = new Size(100, 34);
            button3.TabIndex = 9;
            button3.Text = "Start Workout";
            button3.UseVisualStyleBackColor = true;
            // 
            // todaysWorkoutTable
            // 
            todaysWorkoutTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todaysWorkoutTable.Columns.AddRange(new DataGridViewColumn[] { ExerciseName, Sets, Reps, Weight, Duration, Completed });
            todaysWorkoutTable.Location = new Point(5, 55);
            todaysWorkoutTable.Name = "todaysWorkoutTable";
            todaysWorkoutTable.Size = new Size(643, 163);
            todaysWorkoutTable.TabIndex = 0;
            todaysWorkoutTable.CellContentClick += todaysWorkoutTable_CellContentClick;
            // 
            // ExerciseName
            // 
            ExerciseName.HeaderText = "Exercise Name";
            ExerciseName.Name = "ExerciseName";
            // 
            // Sets
            // 
            Sets.HeaderText = "Sets";
            Sets.Name = "Sets";
            // 
            // Reps
            // 
            Reps.HeaderText = "Reps";
            Reps.Name = "Reps";
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            // 
            // Duration
            // 
            Duration.HeaderText = "Duration";
            Duration.Name = "Duration";
            // 
            // Completed
            // 
            Completed.HeaderText = "Completed";
            Completed.Name = "Completed";
            Completed.Resizable = DataGridViewTriState.True;
            Completed.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // WorkoutNameLabel
            // 
            WorkoutNameLabel.AutoSize = true;
            WorkoutNameLabel.Location = new Point(276, 27);
            WorkoutNameLabel.Name = "WorkoutNameLabel";
            WorkoutNameLabel.Size = new Size(88, 15);
            WorkoutNameLabel.TabIndex = 2;
            WorkoutNameLabel.Text = "Workout Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WorkoutNameLabel);
            groupBox1.Controls.Add(todaysWorkoutTable);
            groupBox1.Location = new Point(114, 52);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(658, 269);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Today's Workout";
            // 
            // workoutLogBindingSource
            // 
            workoutLogBindingSource.DataSource = typeof(Models.Logs.WorkoutLog);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 579);
            Controls.Add(button3);
            Controls.Add(previousBtn);
            Controls.Add(nextBtn);
            Controls.Add(menuBar1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(welcomeTxt);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
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
        private MonthCalendar monthCalendar1;
        private ProgressBar progressBar1;
        private Label label1;
        private UI.MenuBar menuBar1;
        private Button nextBtn;
        private Button previousBtn;
        private Button button3;
        private DataGridView todaysWorkoutTable;
        private DataGridViewTextBoxColumn ExerciseName;
        private DataGridViewTextBoxColumn Sets;
        private DataGridViewTextBoxColumn Reps;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewCheckBoxColumn Completed;
        private Label WorkoutNameLabel;
        private GroupBox groupBox1;
        private BindingSource workoutLogBindingSource;
    }
}
