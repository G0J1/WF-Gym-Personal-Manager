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
    public partial class ActiveWorkout : Form, INavigateable, IProgressBar
    {
        private Workout activeWorkout;
        private WorkoutLog loggedWorkout;
        private int currentExerciseIndex = 0;

        private int enteredSets = -1;
        private int enteredReps = -1;
        private double enteredWeight = -1;
        private int enteredTime = -1;

        private bool timerActive = false;
        private System.Windows.Forms.Timer timer;

        private int currentSecs = 0;


        public ActiveWorkout(Workout w)
        {
            InitializeComponent();
            FormControls.SetupNavigationLayout(menuBar1, tableLayoutPanel1);

            activeWorkout = w;
            workoutName.Text = activeWorkout.name;
            loggedWorkout = new WorkoutLog(w);
            strengthPanel.Visible = false;
            timeBasedPanel.Visible = false;

            if (!(WorkoutService.IsWorkoutActive()))
            {
                WorkoutService.StartActiveWorkout(w);
            }

            SetToggleTimerBtnLabel();


            RefreshScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextPage();

        }

        public void RefreshScreen()
        {
            exerciseLabel.Text = activeWorkout.exercises[currentExerciseIndex].name;

            RefreshProgressBar();

            ExerciseLog log = GetCurrentExerciseActive();
            if (log.loggedExercise is StrengthExercise)
            {
                strengthPanel.Visible = true;
                timeBasedPanel.Visible = false;
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
            else if (log.loggedExercise is TimedExercise)
            {
                strengthPanel.Visible = false;
                timeBasedPanel.Visible = true;
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += OnTimerTick;
                UpdateTimeLbl();
                currentSecs = 0;
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
        private ExerciseLog GetCurrentExerciseActive()
        {
            return WorkoutService.activeWorkoutLog.exerciseLogs[currentExerciseIndex];
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
            WorkoutService.FinishActiveWorkout();
        }

        private bool LogExercise()
        {
            if (GetCurrentExerciseActive().loggedExercise is StrengthExercise)
            {
                if (LogStrengthExercise() == false)
                {
                    return false;
                }
            }
            else if (GetCurrentExerciseActive().loggedExercise is TimedExercise)
            {
                if (LogTimeExercise() == false)
                {
                    return false;
                }
            }
            GetCurrentExerciseActive().completionDate = DateOnly.FromDateTime(DateTime.Now);
            GetCurrentExerciseActive().completed = true;
            return true;
        }

        private bool LogStrengthExercise()
        {
            enteredSets = FormControls.ReturnTextBoxInt(setsBox);
            enteredReps = FormControls.ReturnTextBoxInt(repsBox);
            enteredWeight = FormControls.ReturnTextBoxDoub(weightBox);

            if (enteredWeight == -1 || enteredSets == -1 || enteredReps == -1)
            {
                MessageBox.Show("Invalid Input!");
                return false;
            }
            else if (enteredSets == 0 || enteredReps == 0)
            {
                MessageBox.Show("Exercise not started yet!");
                return false;
            }
            GetCurrentExerciseActive().completionDate = FormControls.GetTodaysDate();
            GetCurrentExerciseActive().recordedSets = enteredSets;
            GetCurrentExerciseActive().recordedReps = enteredReps;
            GetCurrentExerciseActive().recordedWeight = enteredWeight;
            GetCurrentExerciseActive().completed = true;
            return true;
        }

        private bool LogTimeExercise()
        {
            if (currentSecs == 0)
            {
                MessageBox.Show("Exercise not started!");
                return false;
            }

            GetCurrentExerciseActive().recordedTime = TimeSpan.FromSeconds(currentSecs);
            return true;
        }



        private void toggleTimerBtn_Click(object sender, EventArgs e)
        {
            timerActive = !timerActive;
            SetToggleTimerBtnLabel();
            HandleTimer();
        }

        private void SetToggleTimerBtnLabel()
        {
            if (timerActive == true)
            {
                toggleTimerBtn.Text = "Stop";
            }
            else
            {
                toggleTimerBtn.Text = "Start";
            }
        }

        private void HandleTimer()
        {
            if (timerActive)
            {
                timer.Start();
            }
            else if (!timerActive)
            {
                timer.Stop();
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            currentSecs++;
            UpdateTimeLbl();
        }

        private void UpdateTimeLbl()
        {
            int elapsedMins = currentSecs / 60;
            int elapsedSecs = currentSecs % 60;
            string minsText = elapsedMins.ToString();
            string secsText = elapsedSecs.ToString();

            if (elapsedMins < 10)
            {
                minsText = "0" + elapsedMins;
            }
            if (elapsedSecs < 10)
            {
                secsText = "0" + elapsedSecs;
            }

            timeLbl.Text = minsText + " : " + secsText;
        }

        public void RefreshProgressBar()
        {
            // progress bar
            progressBar1.Maximum = Math.Max(1, WorkoutService.activeWorkoutLog.exerciseLogs.Count);

            progressBar1.Value = WorkoutService.activeWorkoutLog.exerciseLogs
                .Count(e => e.completed);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void workoutName_Click(object sender, EventArgs e)
        {

        }
    }
}
