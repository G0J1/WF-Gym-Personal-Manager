using WF_Gym_Personal_Tracker.Models;
using WF_Gym_Personal_Tracker.Forms;

namespace WF_Gym_Personal_Tracker
{
    public partial class Dashboard : Form
    {
        private int currentWorkoutIndex = 0;

        public Dashboard()
        {
            InitializeComponent();
            RefreshWorkoutList();
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

        private void todaysWorkoutTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshWorkoutList()
        {
            setWorkoutNameText(WorkoutService.GetWorkoutName(currentWorkoutIndex));
        }

        private void setWorkoutNameText(string text)
        {
            WorkoutNameLabel.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentWorkoutIndex++;
            if (currentWorkoutIndex > (WorkoutService.maxIndex))
            {
                currentWorkoutIndex = 0;
            }
            RefreshWorkoutList();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            currentWorkoutIndex--;
            if (currentWorkoutIndex < 0)
            {
                currentWorkoutIndex = WorkoutService.maxIndex;
            }
            RefreshWorkoutList();
        }
    }
}
