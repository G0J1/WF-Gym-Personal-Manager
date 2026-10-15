using System;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Forms;

namespace WF_Gym_Personal_Tracker
{
    public partial class WorkoutBuilder : Form
    {
        public WorkoutBuilder()
        {
            InitializeComponent();
            SetupNavigationLayout();

            button1.Click -= btnArmDay_Click;
            button1.Click += btnArmDay_Click;

            button2.Click -= btnLegDay_Click;
            button2.Click += btnLegDay_Click;

            button3.Click -= btnFullBody_Click;
            button3.Click += btnFullBody_Click;
        }

        private void SetupNavigationLayout()
        {
            menuBar1.Dock = DockStyle.Top;
            tableLayoutPanel1.Padding =
                new Padding(0, menuBar1.Height, 0, 0);

            menuBar1.BringToFront();
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
            FormControls.currentWorkoutIndex = workoutIndex;
            WorkoutService.currentDashboardWIndex = workoutIndex;

            using ExerciseSelector selector =
                new ExerciseSelector(workoutIndex);

            selector.ShowDialog(this);
        }
    }
}