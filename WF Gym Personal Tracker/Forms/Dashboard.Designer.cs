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
            welcomeTxt = new Label();
            monthCalendar1 = new MonthCalendar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            todaysWorkoutTable = new DataGridView();
            Completed = new DataGridViewCheckBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Reps = new DataGridViewTextBoxColumn();
            Sets = new DataGridViewTextBoxColumn();
            ExerciseName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)todaysWorkoutTable).BeginInit();
            groupBox1.SuspendLayout();
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
            // button1
            // 
            button1.Location = new Point(784, 195);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(25, 195);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
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
            todaysWorkoutTable.Location = new Point(5, 75);
            todaysWorkoutTable.Name = "todaysWorkoutTable";
            todaysWorkoutTable.Size = new Size(643, 163);
            todaysWorkoutTable.TabIndex = 0;
            todaysWorkoutTable.CellContentClick += todaysWorkoutTable_CellContentClick;
            // 
            // Completed
            // 
            Completed.HeaderText = "Completed";
            Completed.Name = "Completed";
            Completed.Resizable = DataGridViewTriState.True;
            Completed.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Duration
            // 
            Duration.HeaderText = "Duration";
            Duration.Name = "Duration";
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            // 
            // Reps
            // 
            Reps.HeaderText = "Reps";
            Reps.Name = "Reps";
            // 
            // Sets
            // 
            Sets.HeaderText = "Sets";
            Sets.Name = "Sets";
            // 
            // ExerciseName
            // 
            ExerciseName.HeaderText = "Exercise Name";
            ExerciseName.Name = "ExerciseName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 18);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Today's Workout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 43);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Workout Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 579);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTxt;
        private MonthCalendar monthCalendar1;
        private ProgressBar progressBar1;
        private Label label1;
        private UI.MenuBar menuBar1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView todaysWorkoutTable;
        private DataGridViewTextBoxColumn ExerciseName;
        private DataGridViewTextBoxColumn Sets;
        private DataGridViewTextBoxColumn Reps;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewCheckBoxColumn Completed;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
    }
}
