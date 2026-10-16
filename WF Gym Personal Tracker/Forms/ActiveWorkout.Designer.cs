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
            timeLbl = new Label();
            toggleTimerBtn = new Button();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            byttonPanel = new Panel();
            panel1 = new Panel();
            strengthPanel.SuspendLayout();
            timeBasedPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            byttonPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, 1);
            menuBar1.Margin = new Padding(4, 5, 4, 5);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(804, 36);
            menuBar1.TabIndex = 0;
            // 
            // workoutName
            // 
            workoutName.Anchor = AnchorStyles.None;
            workoutName.AutoSize = true;
            workoutName.Location = new Point(285, 13);
            workoutName.Name = "workoutName";
            workoutName.Size = new Size(88, 15);
            workoutName.TabIndex = 1;
            workoutName.Text = "Workout Name";
            workoutName.Click += workoutName_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(140, 70);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(370, 23);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            // 
            // exerciseLabel
            // 
            exerciseLabel.Anchor = AnchorStyles.None;
            exerciseLabel.AutoSize = true;
            exerciseLabel.Location = new Point(283, 55);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(91, 15);
            exerciseLabel.TabIndex = 3;
            exerciseLabel.Text = "Current Exercise";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(140, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Previous Exercise";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(432, 34);
            button2.Name = "button2";
            button2.Size = new Size(78, 26);
            button2.TabIndex = 5;
            button2.Text = "Log";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // strengthPanel
            // 
            strengthPanel.Anchor = AnchorStyles.None;
            strengthPanel.Controls.Add(label3);
            strengthPanel.Controls.Add(label2);
            strengthPanel.Controls.Add(label1);
            strengthPanel.Controls.Add(weightBox);
            strengthPanel.Controls.Add(repsBox);
            strengthPanel.Controls.Add(setsBox);
            strengthPanel.Location = new Point(159, 15);
            strengthPanel.Name = "strengthPanel";
            strengthPanel.Size = new Size(341, 100);
            strengthPanel.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 33);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 33);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Reps";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Sets";
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
            // timeBasedPanel
            // 
            timeBasedPanel.Anchor = AnchorStyles.None;
            timeBasedPanel.Controls.Add(timeLbl);
            timeBasedPanel.Controls.Add(toggleTimerBtn);
            timeBasedPanel.Controls.Add(label4);
            timeBasedPanel.Location = new Point(159, 15);
            timeBasedPanel.Margin = new Padding(2);
            timeBasedPanel.Name = "timeBasedPanel";
            timeBasedPanel.Size = new Size(341, 100);
            timeBasedPanel.TabIndex = 6;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(148, 26);
            timeLbl.Margin = new Padding(2, 0, 2, 0);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(31, 15);
            timeLbl.TabIndex = 2;
            timeLbl.Text = "time";
            // 
            // toggleTimerBtn
            // 
            toggleTimerBtn.Location = new Point(127, 53);
            toggleTimerBtn.Margin = new Padding(2);
            toggleTimerBtn.Name = "toggleTimerBtn";
            toggleTimerBtn.Size = new Size(78, 20);
            toggleTimerBtn.TabIndex = 1;
            toggleTimerBtn.Text = "Start";
            toggleTimerBtn.UseVisualStyleBackColor = true;
            toggleTimerBtn.Click += toggleTimerBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 2);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "Timer";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 598F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(byttonPanel, 0, 3);
            tableLayoutPanel1.Controls.Add(workoutName, 0, 0);
            tableLayoutPanel1.Controls.Add(exerciseLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 168F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.Size = new Size(658, 430);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // byttonPanel
            // 
            byttonPanel.Controls.Add(button2);
            byttonPanel.Controls.Add(progressBar1);
            byttonPanel.Controls.Add(button1);
            byttonPanel.Dock = DockStyle.Fill;
            byttonPanel.Location = new Point(3, 255);
            byttonPanel.Name = "byttonPanel";
            byttonPanel.Size = new Size(652, 172);
            byttonPanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(timeBasedPanel);
            panel1.Controls.Add(strengthPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 162);
            panel1.TabIndex = 8;
            // 
            // ActiveWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 430);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuBar1);
            Name = "ActiveWorkout";
            Text = "ActiveWorkout";
            Load += ActiveWorkout_Load;
            strengthPanel.ResumeLayout(false);
            strengthPanel.PerformLayout();
            timeBasedPanel.ResumeLayout(false);
            timeBasedPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            byttonPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel byttonPanel;
        private Panel panel1;
    }
}