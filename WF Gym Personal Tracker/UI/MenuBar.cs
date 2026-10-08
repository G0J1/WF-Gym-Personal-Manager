using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Models;

namespace WF_Gym_Personal_Tracker.UI
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControls.OpenNewForm(this.FindForm(), new Dashboard());
        }

        private void workoutBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControls.OpenNewForm(this.FindForm(), new WorkoutBuilder());
        }

        private void progressTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControls.OpenNewForm(this.FindForm(), new ProgressTracker());
        }
    }
}
