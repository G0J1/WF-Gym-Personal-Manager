using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Interop;
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

            // if a workout has not been started (this page is opened for the first time on the active date), create a new active workout
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
            // set fields depending on type of exercise
            if (log.loggedExercise is StrengthExercise)
            {
                strengthPanel.Visible = true;
                timeBasedPanel.Visible = false;
                //if there are recorded fields greater than 0, load them up (allows progress to save if active window closed before workout complete)
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
                // creates a new timer, sets its interval as 1 second and binds the it's tick function
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += OnTimerTick;
                UpdateTimeLbl();
                currentSecs = 0;
            }



        }

        public void NextPage()
        {
            // returns early if error in logging exercise
            if (LogExercise() == false)
            {
                return;
            }

            // if checks to make sure index not invalid
            if (currentExerciseIndex < (activeWorkout.exercises.Count - 1))
            {
                currentExerciseIndex++;
                RefreshScreen();
            }
            // after the final exercise is logged, log the full workout and open the dashboard
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
            // set completion status to true and date to active date and then call the function to save the log to the database
            loggedWorkout.completed = true;
            loggedWorkout.completionDate = WorkoutService.activeDate;
            WorkoutService.FinishActiveWorkout();
        }

        private bool LogExercise()
        {
            // if checks to generate and save correct fields depending on subclass of exercise
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
            GetCurrentExerciseActive().completionDate = WorkoutService.activeDate;
            GetCurrentExerciseActive().completed = true;
            return true;
        }

        private bool LogStrengthExercise()
        {
            // saves fields to instance of this form
            enteredSets = FormControls.ReturnTextBoxInt(setsBox);
            enteredReps = FormControls.ReturnTextBoxInt(repsBox);
            enteredWeight = FormControls.ReturnTextBoxDoub(weightBox);

            // check invalid input
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
            GetCurrentExerciseActive().completionDate = WorkoutService.activeDate;
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
            // toggle the timer
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
            //if the timer is active, start it, if inactive, stop it
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
            // increment the recorded seconds and update the label
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
