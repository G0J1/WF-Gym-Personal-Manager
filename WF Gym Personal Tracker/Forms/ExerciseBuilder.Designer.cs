namespace WF_Gym_Personal_Tracker.Forms
{
    partial class ExerciseBuilder
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 103);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 103);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(394, 103);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(234, 148);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(251, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Reps";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Sets";
            // 
            // button2
            // 
            button2.Location = new Point(234, 192);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(0, -2);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(561, 36);
            menuBar1.TabIndex = 8;
            // 
            // ExerciseBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(menuBar1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "ExerciseBuilder";
            Text = "ExerciseBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private UI.MenuBar menuBar1;
    }
}