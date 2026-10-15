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
            RefreshScreen();
            dateLabel.Text = FormControls.GetTodaysDate().ToString();

            string userName = Environment.UserName;
            welcomeTxt.Text = "Welcome " + userName + "!";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void workoutBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControls.OpenNewForm(this, new WorkoutBuilder());
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControls.OpenNewForm(this, new Dashboard());
        }

        private void progressTrackerMenuItem_Click(object sender, EventArgs e)
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
            Workout w = WorkoutService.GetWorkouts()[WorkoutService.currentDashboardWIndex];
            FormControls.OpenNewForm(this, new ActiveWorkout(w));
        }

        public void RefreshScreen()
        {
            var dataRows = WorkoutService.GetExercises(WorkoutService.currentDashboardWIndex).OfType<StrengthExercise>().ToList();
            
            var dataRows2 = WorkoutService.GetExercises(WorkoutService.currentDashboardWIndex).Select(e => new DashboardRow(e, WorkoutService.GetWorkouts()[currentWorkoutIndex])).ToList();

            setWorkoutNameText(WorkoutService.GetWorkoutName(WorkoutService.currentDashboardWIndex));
            todaysWorkoutTable.DataSource = null;
            todaysWorkoutTable.AutoGenerateColumns = false;
            todaysWorkoutTable.DataSource = dataRows2;
            todaysWorkoutTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void NextPage()
        {
            WorkoutService.currentDashboardWIndex++;
            if (WorkoutService.currentDashboardWIndex > (WorkoutService.maxIndex))
            {
                WorkoutService.currentDashboardWIndex = 0;
            }
            RefreshScreen();
        }

        public void PreviousPage()
        {
            WorkoutService.currentDashboardWIndex--;
            if (WorkoutService.currentDashboardWIndex < 0)
            {
                WorkoutService.currentDashboardWIndex = WorkoutService.maxIndex;
            }
            RefreshScreen();
        }
    }
}
