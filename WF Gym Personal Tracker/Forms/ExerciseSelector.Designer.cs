namespace WF_Gym_Personal_Tracker.Forms
{
    partial class ExerciseSelector
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(36, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 279);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(431, 209);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(431, 124);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(431, 303);
            button3.Name = "button3";
            button3.Size = new Size(150, 38);
            button3.TabIndex = 8;
            button3.Text = "Cancel";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 50);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 9;
            label1.Text = "Add An Exercise";
            // 
            // ExerciseSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "ExerciseSelector";
            Text = "ExerciseBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}