namespace WF_Gym_Personal_Tracker
{
    partial class WorkoutBuilder
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(403, 3);
            button1.Name = "button1";
            button1.Size = new Size(166, 62);
            button1.TabIndex = 0;
            button1.Text = "Arm Day";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(403, 111);
            button2.Name = "button2";
            button2.Size = new Size(166, 67);
            button2.TabIndex = 1;
            button2.Text = "Leg Day";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(403, 219);
            button3.Name = "button3";
            button3.Size = new Size(166, 63);
            button3.TabIndex = 2;
            button3.Text = "Full Body";
            button3.UseVisualStyleBackColor = true;
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(-1, 0);
            menuBar1.Margin = new Padding(6, 8, 6, 8);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(803, 60);
            menuBar1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.Size = new Size(800, 348);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // WorkoutBuilder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuBar1);
            Name = "WorkoutBuilder";
            Text = "WorkoutBuilder";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private UI.MenuBar menuBar1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}