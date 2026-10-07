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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(563, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(334, 247);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 143);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 4;
            label1.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(358, 143);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 5;
            label2.Text = "Reps";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 143);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 6;
            label3.Text = "Sets";
            // 
            // button2
            // 
            button2.Location = new Point(334, 320);
            button2.Name = "button2";
            button2.Size = new Size(121, 38);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // ExerciseBuilder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
    }
}