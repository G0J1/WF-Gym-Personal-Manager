using WF_Gym_Personal_Tracker.Models;
using WF_Gym_Personal_Tracker.Forms;
using WF_Gym_Personal_Tracker.Models.Interfaces;

namespace WF_Gym_Personal_Tracker
{
    public partial class Dashboard : Form, INavigateable
    {
        public Dashboard()
        {
            InitializeComponent();

            WorkoutService.currentDashboardWIndex = Math.Clamp(
                FormControls.currentWorkoutIndex,
                0,
                WorkoutService.maxIndex);

            RefreshScreen();
            Activated += (sender, e) => RefreshScreen();

            dateLabel.Text = FormControls.GetTodaysDate().ToString();

            string userName = Environment.UserName;
            welcomeTxt.Text = "Welcome " + userName + "!";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void workoutBuilderToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            FormControls.OpenNewForm(this, new WorkoutBuilder());
        }

        private void dashboardToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            FormControls.OpenNewForm(this, new Dashboard());
        }

        private void progressTrackerMenuItem_Click(
            object sender,
            EventArgs e)
        {
            FormControls.OpenNewForm(this, new ProgressTracker());
        }

        private void setWorkoutNameText(string text)
        {
            WorkoutNameLabel.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WorkoutService.IsWorkoutCompleted())
            {
                MessageBox.Show("Today's workout already completed!");
                return;
            }

            NextPage();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (WorkoutService.IsWorkoutCompleted())
            {
                MessageBox.Show("Today's workout already completed!");
                return;
            }

            PreviousPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WorkoutService.IsWorkoutCompleted())
            {
                MessageBox.Show("Today's workout already completed!");
                return;
            }

            Workout workout =
                WorkoutService.GetWorkouts()[
                    WorkoutService.currentDashboardWIndex];

            if (workout.exercises.Count == 0)
            {
                MessageBox.Show(
                    "Add at least one exercise before starting a workout.");

                return;
            }

            FormControls.OpenNewForm(
                this,
                new ActiveWorkout(workout));
        }

        public void RefreshScreen()
        {
            int workoutIndex =
                WorkoutService.currentDashboardWIndex;

            FormControls.currentWorkoutIndex = workoutIndex;

            Workout workout =
                WorkoutService.GetWorkouts()[workoutIndex];

            var dataRows = WorkoutService
                .GetExercises(workoutIndex)
                .Select(exercise =>
                    new DashboardRow(exercise, workout))
                .ToList();

            setWorkoutNameText(
                WorkoutService.GetWorkoutName(workoutIndex));

            todaysWorkoutTable.DataSource = null;
            todaysWorkoutTable.AutoGenerateColumns = false;
            todaysWorkoutTable.DataSource = dataRows;
            todaysWorkoutTable.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void NextPage()
        {
            WorkoutService.currentDashboardWIndex++;

            if (WorkoutService.currentDashboardWIndex >
                WorkoutService.maxIndex)
            {
                WorkoutService.currentDashboardWIndex = 0;
            }

            FormControls.currentWorkoutIndex =
                WorkoutService.currentDashboardWIndex;

            RefreshScreen();
        }

        public void PreviousPage()
        {
            WorkoutService.currentDashboardWIndex--;

            if (WorkoutService.currentDashboardWIndex < 0)
            {
                WorkoutService.currentDashboardWIndex =
                    WorkoutService.maxIndex;
            }

            FormControls.currentWorkoutIndex =
                WorkoutService.currentDashboardWIndex;

            RefreshScreen();
        }
    }
}