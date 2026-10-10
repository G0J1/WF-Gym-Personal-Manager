using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using WF_Gym_Personal_Tracker.Models.Logs;

namespace WF_Gym_Personal_Tracker
{
    public partial class ProgressTracker : Form
    {
        private List<WorkoutLog> workoutLogs;

        public ProgressTracker()
        {
            InitializeComponent();

            //workoutLogs = new List<WorkoutLog>();
            LoadWorkoutNames();
            LoadExerciseNames();
        }

        private void LoadWorkoutNames()
        {
            var workoutNames = WorkoutService.GetWorkouts()
                .Select(w => w.name)
                .ToList();

            cmbWorkout.DataSource = workoutNames;
        }

        private void LoadExerciseNames()
        {
            var exerciseNames = WorkoutService.GetWorkouts()
                .SelectMany(w => w.exercises)
                .Select(e => e.name)
                .Distinct()
                .ToList();

            cmbExercise.DataSource = exerciseNames;
        }

        private void UpdateStatistics()
        {
            if (cmbExercise.SelectedItem == null)
            {
                return;
            }

            string selectedExercise = cmbExercise.SelectedItem.ToString();

            var exerciseLogs = WorkoutService.GetWorkoutLogs()
                .SelectMany(w => w.exerciseLogs)
                .Where(e => e.loggedExercise.name == selectedExercise)
                .Where(e => e.completed)
                .ToList();

            if (exerciseLogs.Count == 0)
            {
                return;
            }

            double maxWeight = exerciseLogs.Max(e => e.recordedWeight);
            int maxReps = exerciseLogs.Max(e => e.recordedReps);
            double averageReps = exerciseLogs.Average(e => e.recordedReps);

            double totalVolume = exerciseLogs
                .Sum(e => e.recordedWeight * e.recordedReps * e.recordedSets);
        }

        private void cmbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
