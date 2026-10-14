using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Forms;

namespace WF_Gym_Personal_Tracker
{
    public partial class WorkoutBuilder : Form
    {
        public WorkoutBuilder()
        {
            InitializeComponent();
        }

        private void btnArmDay_Click(object sender, EventArgs e)
        {
            ExerciseSelector exerciseSelector = new ExerciseSelector();
            exerciseSelector.ShowDialog();
        }
    }
}
