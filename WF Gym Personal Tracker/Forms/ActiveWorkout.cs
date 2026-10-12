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
using WF_Gym_Personal_Tracker.Models.Interfaces;
using WF_Gym_Personal_Tracker.Models.Logs;

namespace WF_Gym_Personal_Tracker.Forms
{
    public partial class ActiveWorkout : Form, INavigateable
    {
        private Workout activeWorkout;
        private WorkoutLog loggedWorkout;
        private int currentExerciseIndex = 0;


        public ActiveWorkout(Workout w)
        {
            InitializeComponent();
            activeWorkout = w;
            workoutName.Text = activeWorkout.name;
            loggedWorkout = new WorkoutLog(w);
            RefreshScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextPage();

        }

        public void RefreshScreen()
        {
            exerciseLabel.Text = activeWorkout.exercises[currentExerciseIndex].name;
        }

        public void NextPage()
        {
            if (currentExerciseIndex < (activeWorkout.exercises.Count - 1))
            {
                currentExerciseIndex++;
                RefreshScreen();
            }
            else
            {
                WorkoutService.AddWorkLog(loggedWorkout);
                FormControls.OpenNewForm(this, new Dashboard());

            }
        }

        public void PreviousPage()
        {
            if (currentExerciseIndex > 0)
            {
                currentExerciseIndex--;
                RefreshScreen();
            }
        }

        private void ActiveWorkout_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
    }
}
