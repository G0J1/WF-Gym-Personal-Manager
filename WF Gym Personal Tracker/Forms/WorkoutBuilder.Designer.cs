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
            btnArmDay = new Button();
            btnLegDay = new Button();
            btnFullBody = new Button();
            menuBar1 = new WF_Gym_Personal_Tracker.UI.MenuBar();
            SuspendLayout();
            // 
            // btnArmDay
            // 
            btnArmDay.Location = new Point(299, 68);
            btnArmDay.Name = "btnArmDay";
            btnArmDay.Size = new Size(166, 62);
            btnArmDay.TabIndex = 0;
            btnArmDay.Text = "Arm Day";
            btnArmDay.UseVisualStyleBackColor = true;
            btnArmDay.Click += btnArmDay_Click;
            // 
            // btnLegDay
            // 
            btnLegDay.Location = new Point(299, 158);
            btnLegDay.Name = "btnLegDay";
            btnLegDay.Size = new Size(166, 67);
            btnLegDay.TabIndex = 1;
            btnLegDay.Text = "Leg Day";
            btnLegDay.UseVisualStyleBackColor = true;
            // 
            // btnFullBody
            // 
            btnFullBody.Location = new Point(299, 253);
            btnFullBody.Name = "btnFullBody";
            btnFullBody.Size = new Size(166, 63);
            btnFullBody.TabIndex = 2;
            btnFullBody.Text = "Full Body";
            btnFullBody.UseVisualStyleBackColor = true;
            // 
            // menuBar1
            // 
            menuBar1.Location = new Point(-1, 0);
            menuBar1.Margin = new Padding(6, 8, 6, 8);
            menuBar1.Name = "menuBar1";
            menuBar1.Size = new Size(803, 60);
            menuBar1.TabIndex = 3;
            // 
            // WorkoutBuilder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            Controls.Add(menuBar1);
            Controls.Add(btnFullBody);
            Controls.Add(btnLegDay);
            Controls.Add(btnArmDay);
            Name = "WorkoutBuilder";
            Text = "WorkoutBuilder";
            ResumeLayout(false);
        }

        #endregion

        private Button btnArmDay;
        private Button btnLegDay;
        private Button btnFullBody;
        private UI.MenuBar menuBar1;
    }
}