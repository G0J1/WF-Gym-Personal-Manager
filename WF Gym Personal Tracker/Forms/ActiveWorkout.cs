using Microsoft.VisualBasic.Logging;
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

        private int enteredSets = -1;
        private int enteredReps = -1;
        private double enteredWeight = -1;


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
            ExerciseLog log = GetCurrentExercise();

            exerciseLabel.Text = activeWorkout.exercises[currentExerciseIndex].name;
            if (log.recordedReps >= 0)
            {
                setsBox.Text = log.recordedSets.ToString();
            }
            else
            {
                setsBox.Clear();
            }
            

            if (log.recordedReps >= 0)
            {
                repsBox.Text = log.recordedReps.ToString();
            }
            else
            {
                repsBox.Clear();
            }

            if (log.recordedWeight >= 0)
            {
                weightBox.Text = log.recordedWeight.ToString();
            }
            else
            {
                weightBox.Clear();
            }
        }

        public void NextPage()
        {
            if (LogExercise() == false)
            {
                return;
            }
            
            if (currentExerciseIndex < (activeWorkout.exercises.Count - 1))
            {
                currentExerciseIndex++;
                RefreshScreen();
            }
            else
            {
                LogWorkout();
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
        private ExerciseLog GetCurrentExercise()
        {
            return loggedWorkout.exerciseLogs[currentExerciseIndex];
        }

        private void setsBox_TextChanged(object sender, EventArgs e)
        {
            /*enteredSets = FormControls.ReturnTextBoxInt(setsBox);*/
        }

        private void repsBox_TextChanged(object sender, EventArgs e)
        {
           /* enteredReps = FormControls.ReturnTextBoxInt(repsBox);*/
        }

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
/*            enteredWeight = FormControls.ReturnTextBoxDoub(weightBox);*/
        }

        private void LogWorkout()
        {
            loggedWorkout.completed = true;
            loggedWorkout.completionDate = DateOnly.FromDateTime(DateTime.Now);
            WorkoutService.AddWorkLog(loggedWorkout);
        }

        private bool LogExercise()
        {
            enteredSets = FormControls.ReturnTextBoxInt(setsBox);
            enteredReps = FormControls.ReturnTextBoxInt(repsBox);
            enteredWeight = FormControls.ReturnTextBoxDoub(weightBox);

            if (enteredWeight == -1 ||  enteredSets == -1 || enteredReps == -1)
            {
                MessageBox.Show("Invalid Input!");
                return false;
            }
            GetCurrentExercise().completionDate = DateOnly.FromDateTime(DateTime.Now);
            GetCurrentExercise().recordedSets = enteredSets;
            GetCurrentExercise().recordedReps = enteredReps;
            GetCurrentExercise().recordedWeight = enteredWeight;
            GetCurrentExercise().completed = true;
            return true;
        }
    }
}
