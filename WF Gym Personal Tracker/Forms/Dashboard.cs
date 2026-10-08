using WF_Gym_Personal_Tracker.Models;
using WF_Gym_Personal_Tracker.Forms;

namespace WF_Gym_Personal_Tracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
    }
}
