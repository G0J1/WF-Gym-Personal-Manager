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
            workoutProgressBar = new ProgressBar();
            quoteLabel = new Label();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)todaysWorkoutTable).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workoutLogBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.Anchor = AnchorStyles.None;
            welcomeTxt.AutoSize = true;
            welcomeTxt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            welcomeTxt.ForeColor = Color.FromArgb(64, 64, 64);
            welcomeTxt.Location = new Point(384, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(99, 28);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "Welcome";
            // 
            // workoutProgressBar
            // 
            workoutProgressBar.Anchor = AnchorStyles.None;
            workoutProgressBar.Location = new Point(307, 435);
            workoutProgressBar.Margin = new Padding(2);
            workoutProgressBar.Name = "workoutProgressBar";
            workoutProgressBar.Size = new Size(253, 15);
            workoutProgressBar.TabIndex = 4;
            // 
            // quoteLabel
            // 
            quoteLabel.Anchor = AnchorStyles.None;
            quoteLabel.AutoSize = true;
            quoteLabel.Location = new Point(415, 465);
            quoteLabel.Margin = new Padding(2, 0, 2, 0);
            quoteLabel.Name = "quoteLabel";
            quoteLabel.Size = new Size(38, 15);
            quoteLabel.TabIndex = 5;
            quoteLabel.Text = "quote";
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(-1, -1);
            menuBar1.Margin = new Padding(4, 5, 4, 5);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(908, 36);
            menuBar1.TabIndex = 6;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.Location = new Point(810, 178);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 7;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += button1_Click;
            // 
            // previousBtn
            // 
            previousBtn.Anchor = AnchorStyles.None;
            previousBtn.Location = new Point(3, 178);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(75, 23);
            previousBtn.TabIndex = 8;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(384, 358);
            button3.Name = "button3";
            button3.Size = new Size(100, 34);
            button3.TabIndex = 9;
            button3.Text = "Start Workout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // todaysWorkoutTable
            // 
            todaysWorkoutTable.AllowUserToAddRows = false;
            todaysWorkoutTable.AllowUserToDeleteRows = false;
            todaysWorkoutTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todaysWorkoutTable.Columns.AddRange(new DataGridViewColumn[] { ExerciseName, Sets, Reps, Weight, Duration, Completed });
            todaysWorkoutTable.Dock = DockStyle.Bottom;
            todaysWorkoutTable.Location = new Point(2, 57);
            todaysWorkoutTable.Name = "todaysWorkoutTable";
            todaysWorkoutTable.ReadOnly = true;
            todaysWorkoutTable.RowHeadersWidth = 62;
            todaysWorkoutTable.Size = new Size(694, 200);
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
            WorkoutNameLabel.Location = new Point(276, 27);
            WorkoutNameLabel.Name = "WorkoutNameLabel";
            WorkoutNameLabel.Size = new Size(88, 15);
            WorkoutNameLabel.TabIndex = 2;
            WorkoutNameLabel.Text = "Workout Name";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(WorkoutNameLabel);
            groupBox1.Controls.Add(todaysWorkoutTable);
            groupBox1.Location = new Point(85, 60);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(698, 259);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Today's Workout";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.None;
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(415, 36);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(38, 15);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.545455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.4545441F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.Controls.Add(welcomeTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(nextBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(previousBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(button3, 1, 3);
            tableLayoutPanel1.Controls.Add(dateLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(workoutProgressBar, 1, 4);
            tableLayoutPanel1.Controls.Add(quoteLabel, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.Size = new Size(909, 626);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(909, 626);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuBar1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)todaysWorkoutTable).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workoutLogBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTxt;
        private ProgressBar workoutProgressBar;
        private Label quoteLabel;
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}
