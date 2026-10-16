using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Models.Logs;

namespace WF_Gym_Personal_Tracker
{
    public partial class ProgressTracker : Form
    {
        private List<ExerciseLog> selectedLogs =
            new List<ExerciseLog>();

        private bool isLoading = true;

        public ProgressTracker()
        {
            InitializeComponent();
            FormControls.SetupNavigationLayout(menuBar1, tableLayoutPanel2);

            LoadWorkoutNames();
            LoadExerciseNames();

            isLoading = false;
            UpdateAllResults();
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
            if (cmbWorkout.SelectedItem == null)
            {
                return;
            }

            string selectedWorkout =
                cmbWorkout.SelectedItem.ToString() ?? "";

            var exerciseNames = WorkoutService.GetWorkouts()
                .Where(w => w.name == selectedWorkout)
                .SelectMany(w => w.exercises)
                .Select(e => e.name)
                .Distinct()
                .ToList();

            cmbExercise.DataSource = exerciseNames;
        }

        private void UpdateAllResults()
        {
            UpdateStatistics();
            UpdatePersonalRecords();
            UpdateProgressGraph();
            UpdateFrequencyGraph();
        }

        private void UpdateProgressGraph()
        {
            progressGraph.Plot.Clear();

            var dailyWeights = selectedLogs
                .GroupBy(e => e.completionDate)
                .OrderBy(group => group.Key)
                .Select(group => new
                {
                    Date = group.Key,
                    Weight = group.Max(e => e.recordedWeight)
                })
                .ToList();

            if (dailyWeights.Count > 0)
            {
                double[] dates = dailyWeights
                    .Select(e => e.Date
                        .ToDateTime(TimeOnly.MinValue)
                        .ToOADate())
                    .ToArray();

                double[] weights = dailyWeights
                    .Select(e => e.Weight)
                    .ToArray();

                progressGraph.Plot.Add.Scatter(dates, weights);
                progressGraph.Plot.Axes.DateTimeTicksBottom();
            }

            progressGraph.Plot.Title("Weight Progress");
            progressGraph.Plot.XLabel("Date");
            progressGraph.Plot.YLabel("Weight (kg)");

            progressGraph.Plot.Axes.AutoScale();
            progressGraph.Refresh();
        }

        private void UpdateFrequencyGraph()
        {
            frequencyGraph.Plot.Clear();

            DateOnly today =
                DateOnly.FromDateTime(DateTime.Today);

            int daysFromMonday =
                ((int)today.DayOfWeek + 6) % 7;

            DateOnly firstMonday =
                today.AddDays(-daysFromMonday - 21);

            var completedWorkouts = WorkoutService
                .GetWorkoutLogs()
                .Where(w => w.completed)
                .ToList();

            double[] counts = Enumerable.Range(0, 4)
                .Select(week =>
                {
                    DateOnly start =
                        firstMonday.AddDays(week * 7);

                    DateOnly end = start.AddDays(7);

                    return (double)completedWorkouts.Count(w =>
                        w.completionDate >= start &&
                        w.completionDate < end);
                })
                .ToArray();

            var bars = frequencyGraph.Plot.Add.Bars(counts);
            bars.ValueLabelStyle.IsVisible = true;

            frequencyGraph.Plot.Title("Workouts Per Week");
            frequencyGraph.Plot.XLabel("Week");
            frequencyGraph.Plot.YLabel("Completed Workouts");

            frequencyGraph.Plot.Axes.AutoScale();
            frequencyGraph.Refresh();
        }

        private void UpdateStatistics()
        {
            if (cmbWorkout.SelectedItem == null ||
                cmbExercise.SelectedItem == null)
            {
                selectedLogs.Clear();
                ClearStatistics();
                return;
            }

            string selectedWorkout =
                cmbWorkout.SelectedItem.ToString() ?? "";

            string selectedExercise =
                cmbExercise.SelectedItem.ToString() ?? "";

            selectedLogs = WorkoutService.GetWorkoutLogs()
                .Where(w =>
                    w.completed &&
                    w.workout.name == selectedWorkout)
                .SelectMany(w => w.exerciseLogs)
                .Where(e =>
                    e.completed &&
                    e.loggedExercise.name == selectedExercise)
                .OrderBy(e => e.completionDate)
                .ToList();

            if (selectedLogs.Count == 0)
            {
                ClearStatistics();
                return;
            }

            double maxWeight =
                selectedLogs.Max(e => e.recordedWeight);

            int maxReps =
                selectedLogs.Max(e => e.recordedReps);

            double averageReps =
                selectedLogs.Average(e => e.recordedReps);

            double totalVolume = selectedLogs.Sum(e =>
                e.recordedWeight *
                e.recordedReps *
                e.recordedSets);

            int sessions = selectedLogs
                .Select(e => e.completionDate)
                .Distinct()
                .Count();

            var bestSet = selectedLogs
                .OrderByDescending(e => e.recordedWeight)
                .ThenByDescending(e => e.recordedReps)
                .First();

            lblMaxWeight.Text =
                maxWeight.ToString("0.0") + " kg";

            lblMaxReps.Text = maxReps.ToString();

            lblAverageReps.Text =
                averageReps.ToString("0.0");

            lblTotalVolume.Text =
                totalVolume.ToString("0.0") + " kg";

            lblSessions.Text = sessions.ToString();

            lblBestSet.Text =
                bestSet.recordedWeight.ToString("0.0") +
                " kg x " +
                bestSet.recordedReps;
        }

        private void ClearStatistics()
        {
            lblMaxWeight.Text = "-";
            lblMaxReps.Text = "-";
            lblAverageReps.Text = "-";
            lblTotalVolume.Text = "-";
            lblSessions.Text = "0";
            lblBestSet.Text = "-";
        }

        private void UpdatePersonalRecords()
        {
            recordsList.Items.Clear();

            var records = WorkoutService.GetWorkoutLogs()
                .Where(w => w.completed)
                .SelectMany(w => w.exerciseLogs)
                .Where(e => e.completed)
                .GroupBy(e => e.loggedExercise.name)
                .Select(group => group
                    .OrderByDescending(e => e.recordedWeight)
                    .ThenByDescending(e => e.recordedReps)
                    .First())
                .OrderByDescending(e => e.completionDate)
                .Take(10)
                .ToList();

            if (records.Count == 0)
            {
                recordsList.Items.Add("No records yet.");
                return;
            }

            foreach (ExerciseLog log in records)
            {
                recordsList.Items.Add(
                    log.loggedExercise.name +
                    " - " +
                    log.recordedWeight.ToString("0.0") +
                    " kg x " +
                    log.recordedReps);
            }
        }

        private void ProgressGraph_Paint(
            object sender,
            PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.White);

            var points = selectedLogs
                .GroupBy(log => log.completionDate)
                .OrderBy(group => group.Key)
                .Select(group => new
                {
                    Date = group.Key,
                    Weight = group.Max(
                        log => log.recordedWeight)
                })
                .ToList();

            if (points.Count == 0)
            {
                graphics.DrawString(
                    "No workout data yet.",
                    Font,
                    Brushes.Gray,
                    15,
                    15);

                return;
            }
        }

        private void cmbWorkout_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            LoadExerciseNames();
            UpdateAllResults();
        }

        private void cmbExercise_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            UpdateAllResults();
        }

        private void dateTimePicker1_ValueChanged(
            object sender,
            EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(
            object sender,
            DateRangeEventArgs e)
        {
        }

        private void grpProgress_Enter(
            object sender,
            EventArgs e)
        {
        }
    }
}