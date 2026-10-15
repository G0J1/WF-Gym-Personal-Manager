using System;
using System.Drawing;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Forms;

namespace WF_Gym_Personal_Tracker
{
    public partial class WorkoutBuilder : Form
    {
        public WorkoutBuilder()
        {
            InitializeComponent();
            SetupResponsiveLayout();

            btnArmDay.Click -= btnArmDay_Click;
            btnArmDay.Click += btnArmDay_Click;

            btnLegDay.Click -= btnLegDay_Click;
            btnLegDay.Click += btnLegDay_Click;

            btnFullBody.Click -= btnFullBody_Click;
            btnFullBody.Click += btnFullBody_Click;
        }

        private void SetupResponsiveLayout()
        {
            SuspendLayout();

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 60F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            TableLayoutPanel centreLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 3,
                Padding = new Padding(20)
            };

            centreLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 30F));

            centreLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 40F));

            centreLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 30F));

            centreLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 10F));

            centreLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 80F));

            centreLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 10F));

            TableLayoutPanel buttonLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(10)
            };

            buttonLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            buttonLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 30F));

            buttonLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 5F));

            buttonLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 30F));

            buttonLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 5F));

            buttonLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 30F));

            btnArmDay.Dock = DockStyle.Fill;
            btnLegDay.Dock = DockStyle.Fill;
            btnFullBody.Dock = DockStyle.Fill;

            btnArmDay.Margin = new Padding(8);
            btnLegDay.Margin = new Padding(8);
            btnFullBody.Margin = new Padding(8);

            buttonLayout.Controls.Add(btnArmDay, 0, 0);
            buttonLayout.Controls.Add(btnLegDay, 0, 2);
            buttonLayout.Controls.Add(btnFullBody, 0, 4);

            centreLayout.Controls.Add(buttonLayout, 1, 1);

            menuBar1.Dock = DockStyle.Fill;

            Controls.Clear();

            mainLayout.Controls.Add(menuBar1, 0, 0);
            mainLayout.Controls.Add(centreLayout, 0, 1);

            Controls.Add(mainLayout);

            MinimumSize = new Size(560, 400);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;

            ResumeLayout(true);
        }

        private void WorkoutBuilder_Load(object? sender, EventArgs e)
        {
        }

        private void btnArmDay_Click(object? sender, EventArgs e)
        {
            OpenWorkout(0);
        }

        private void btnLegDay_Click(object? sender, EventArgs e)
        {
            OpenWorkout(1);
        }

        private void btnFullBody_Click(object? sender, EventArgs e)
        {
            OpenWorkout(2);
        }

        private void OpenWorkout(int workoutIndex)
        {
            using ExerciseSelector selector =
                new ExerciseSelector(workoutIndex);

            selector.ShowDialog(this);
        }
    }
}