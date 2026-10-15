using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Models;

namespace WF_Gym_Personal_Tracker.Forms
{
    public partial class ExerciseSelector : Form
    {
        private readonly int workoutIndex;
        private readonly List<Exercise> draftExercises;
        private bool hasUnsavedChanges;

        private readonly Label categoryLabel = new Label();
        private readonly Label countLabel = new Label();
        private readonly Label detailsLabel = new Label();
        private readonly Button editButton = new Button();
        private readonly Button saveButton = new Button();

        public ExerciseSelector() : this(0)
        {
        }

        public ExerciseSelector(int index)
        {
            InitializeComponent();
            SetupResponsiveLayout();

            workoutIndex = index;

            // A separate list lets the user cancel without saving changes.
            draftExercises =
                WorkoutService.GetExercises(index)
                    .Select(WorkoutService.CloneExercise)
                    .ToList();

            Text =
                WorkoutService.GetWorkoutName(index)
                + " - Workout Builder";

            label1.Text =
                WorkoutService.GetWorkoutName(index);

            categoryLabel.Text = index == 0
                ? "Upper-body exercise library"
                : index == 1
                    ? "Lower-body exercise library"
                    : "Full-body exercise library";

            listBox1.DisplayMember =
                nameof(Exercise.name);

            listBox2.DisplayMember =
                nameof(Exercise.name);

            listBox1.DataSource =
                WorkoutService.GetAvailableExercises(index);

            RefreshCurrentExercises();
        }

        private void SetupResponsiveLayout()
        {
            SuspendLayout();

            TableLayoutPanel mainLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 3,
                    RowCount = 8,
                    Padding = new Padding(20)
                };

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 38F));

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 38F));

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 24F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 0F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 40F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 30F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 28F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 30F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 55F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 55F));

            label1.Dock = DockStyle.Fill;
            label1.TextAlign =
                ContentAlignment.MiddleCenter;

            categoryLabel.Dock = DockStyle.Fill;
            categoryLabel.TextAlign =
                ContentAlignment.MiddleCenter;

            label2.Dock = DockStyle.Fill;
            label3.Dock = DockStyle.Fill;

            label2.TextAlign =
                ContentAlignment.BottomLeft;

            label3.TextAlign =
                ContentAlignment.BottomLeft;

            listBox1.Dock = DockStyle.Fill;
            listBox2.Dock = DockStyle.Fill;

            listBox1.IntegralHeight = false;
            listBox2.IntegralHeight = false;

            listBox1.Margin = new Padding(4);
            listBox2.Margin = new Padding(4);

            listBox1.TabIndex = 0;
            listBox2.TabIndex = 1;

            TableLayoutPanel actionLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 1,
                    RowCount = 6,
                    Padding =
                        new Padding(10, 4, 4, 4)
                };

            actionLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));

            actionLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            actionLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    12F));

            actionLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            actionLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    12F));

            actionLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            actionLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            button2.Text = "Add...";
            editButton.Text = "Edit Details...";
            button1.Text = "Delete";

            button2.Dock = DockStyle.Fill;
            editButton.Dock = DockStyle.Fill;
            button1.Dock = DockStyle.Fill;

            button2.TabIndex = 2;
            editButton.TabIndex = 3;
            button1.TabIndex = 4;

            actionLayout.Controls.Add(
                button2,
                0,
                0);

            actionLayout.Controls.Add(
                editButton,
                0,
                2);

            actionLayout.Controls.Add(
                button1,
                0,
                4);

            countLabel.Dock = DockStyle.Fill;

            countLabel.TextAlign =
                ContentAlignment.MiddleLeft;

            detailsLabel.Dock = DockStyle.Fill;

            detailsLabel.TextAlign =
                ContentAlignment.MiddleLeft;

            detailsLabel.AutoEllipsis = true;

            TableLayoutPanel bottomLayout =
                new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 3,
                    RowCount = 1,
                    Margin = Padding.Empty
                };

            bottomLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    56F));

            bottomLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    22F));

            bottomLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    22F));

            bottomLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            saveButton.Text = "Save Workout";
            button3.Text = "Cancel";

            saveButton.Dock = DockStyle.Fill;
            button3.Dock = DockStyle.Fill;

            saveButton.Margin = new Padding(5);
            button3.Margin = new Padding(5);

            saveButton.TabIndex = 5;
            button3.TabIndex = 6;

            button3.TextAlign =
                ContentAlignment.MiddleCenter;

            bottomLayout.Controls.Add(
                saveButton,
                1,
                0);

            bottomLayout.Controls.Add(
                button3,
                2,
                0);

            mainLayout.Controls.Add(
                menuBar1,
                0,
                0);

            mainLayout.SetColumnSpan(
                menuBar1,
                3);

            mainLayout.Controls.Add(
                label1,
                0,
                1);

            mainLayout.SetColumnSpan(
                label1,
                3);

            mainLayout.Controls.Add(
                categoryLabel,
                0,
                2);

            mainLayout.SetColumnSpan(
                categoryLabel,
                3);

            mainLayout.Controls.Add(
                label2,
                0,
                3);

            mainLayout.Controls.Add(
                label3,
                1,
                3);

            mainLayout.Controls.Add(
                listBox1,
                0,
                4);

            mainLayout.Controls.Add(
                listBox2,
                1,
                4);

            mainLayout.Controls.Add(
                actionLayout,
                2,
                4);

            mainLayout.Controls.Add(
                countLabel,
                1,
                5);

            mainLayout.SetColumnSpan(
                countLabel,
                2);

            mainLayout.Controls.Add(
                detailsLabel,
                0,
                6);

            mainLayout.SetColumnSpan(
                detailsLabel,
                3);

            mainLayout.Controls.Add(
                bottomLayout,
                0,
                7);

            mainLayout.SetColumnSpan(
                bottomLayout,
                3);

            menuBar1.Visible = false;

            listBox1.SelectedIndexChanged -=
                listBox1_SelectedIndexChanged;

            listBox1.SelectedIndexChanged +=
                listBox1_SelectedIndexChanged;

            listBox2.SelectedIndexChanged -=
                listBox2_SelectedIndexChanged;

            listBox2.SelectedIndexChanged +=
                listBox2_SelectedIndexChanged;

            button2.Click -= button2_Click;
            button2.Click += button2_Click;

            editButton.Click -= EditDetails_Click;
            editButton.Click += EditDetails_Click;

            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            saveButton.Click -= SaveWorkout_Click;
            saveButton.Click += SaveWorkout_Click;

            button3.Click -= button3_Click;
            button3.Click += button3_Click;

            FormClosing -= ExerciseSelector_FormClosing;
            FormClosing += ExerciseSelector_FormClosing;

            Controls.Clear();
            Controls.Add(mainLayout);

            MinimumSize = new Size(760, 560);
            StartPosition =
                FormStartPosition.CenterParent;

            FormBorderStyle =
                FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = false;

            ResumeLayout(true);
        }

        private void RefreshCurrentExercises(
            int selectedIndex = -1)
        {
            listBox2.DataSource = null;

            listBox2.DataSource =
                draftExercises.ToList();

            // Resetting the DataSource also clears DisplayMember.
            listBox2.DisplayMember =
                nameof(Exercise.name);

            listBox2.SelectedIndex =
                selectedIndex >= 0
                && selectedIndex < draftExercises.Count
                    ? selectedIndex
                    : -1;

            countLabel.Text =
                draftExercises.Count
                + " exercise(s) in this workout";

            UpdateDetails();
        }

        private void button2_Click(
            object? sender,
            EventArgs e)
        {
            if (listBox1.SelectedItem
                is not Exercise template)
            {
                MessageBox.Show(
                    this,
                    "Select an exercise from Available Exercises first.",
                    "Select an exercise",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            bool alreadyAdded =
                draftExercises.Any(exercise =>
                    string.Equals(
                        exercise.name,
                        template.name,
                        StringComparison.OrdinalIgnoreCase));

            if (alreadyAdded)
            {
                MessageBox.Show(
                    this,
                    "This exercise is already in your workout. "
                    + "Select it in Current Exercises and click "
                    + "Edit Details to change its targets.",
                    "Already added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using ExerciseBuilder builder =
                new ExerciseBuilder(template);

            if (builder.ShowDialog(this)
                    == DialogResult.OK
                && builder.BuiltExercise
                    is Exercise configuredExercise)
            {
                draftExercises.Add(
                    configuredExercise);

                hasUnsavedChanges = true;

                RefreshCurrentExercises(
                    draftExercises.Count - 1);
            }
        }

        private void EditDetails_Click(
            object? sender,
            EventArgs e)
        {
            if (listBox2.SelectedItem
                is not Exercise selectedExercise)
            {
                MessageBox.Show(
                    this,
                    "Select an exercise from Current Exercises first.",
                    "Select an exercise",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int selectedIndex =
                listBox2.SelectedIndex;

            using ExerciseBuilder builder =
                new ExerciseBuilder(
                    selectedExercise,
                    true);

            if (builder.ShowDialog(this)
                    == DialogResult.OK
                && builder.BuiltExercise
                    is Exercise configuredExercise)
            {
                draftExercises[selectedIndex] =
                    configuredExercise;

                hasUnsavedChanges = true;

                RefreshCurrentExercises(
                    selectedIndex);
            }
        }

        private void button1_Click(
            object? sender,
            EventArgs e)
        {
            int selectedIndex =
                listBox2.SelectedIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show(
                    this,
                    "Select an exercise from Current Exercises first.",
                    "Select an exercise",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            string exerciseName =
                draftExercises[selectedIndex].name;

            DialogResult confirmation =
                MessageBox.Show(
                    this,
                    "Remove "
                    + exerciseName
                    + " from this workout?",
                    "Remove exercise",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            // Removing it here does not remove it from the exercise library.
            draftExercises.RemoveAt(
                selectedIndex);

            hasUnsavedChanges = true;

            RefreshCurrentExercises(
                Math.Min(
                    selectedIndex,
                    draftExercises.Count - 1));
        }

        private void SaveWorkout_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                WorkoutService.SaveWorkoutExercises(
                    workoutIndex,
                    draftExercises);

                FormControls.currentWorkoutIndex =
                    workoutIndex;

                hasUnsavedChanges = false;

                MessageBox.Show(
                    this,
                    "Workout saved. Open Dashboard to see the updated exercises.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Cannot save workout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(
            object? sender,
            EventArgs e)
        {
            Close();
        }

        private void ExerciseSelector_FormClosing(
            object? sender,
            FormClosingEventArgs e)
        {
            if (!hasUnsavedChanges)
            {
                return;
            }

            DialogResult confirmation =
                MessageBox.Show(
                    this,
                    "Discard your unsaved workout changes?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void listBox1_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (listBox1.SelectedItem
                is Exercise exercise)
            {
                detailsLabel.Text =
                    "Library defaults: "
                    + DescribeExercise(exercise);
            }
        }

        private void listBox2_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            detailsLabel.Text =
                listBox2.SelectedItem
                    is Exercise exercise
                    ? "Selected: "
                        + DescribeExercise(exercise)
                    : "Select a current exercise to view its targets.";
        }

        private static string DescribeExercise(
            Exercise exercise)
        {
            if (exercise
                is StrengthExercise strength)
            {
                return
                    $"{strength.name}: "
                    + $"{strength.targetedSets} sets × "
                    + $"{strength.targetedReps} reps, "
                    + $"{strength.targetedWeight:0.##} kg";
            }

            if (exercise
                is TimedExercise timed)
            {
                return
                    $"{timed.name}: "
                    + $"{timed.targetedTime:c}";
            }

            return exercise.name;
        }
    }
}