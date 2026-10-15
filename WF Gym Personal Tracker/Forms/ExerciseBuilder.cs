using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WF_Gym_Personal_Tracker.Models;

namespace WF_Gym_Personal_Tracker.Forms
{
    public partial class ExerciseBuilder : Form
    {
        private readonly Exercise template;

        public Exercise? BuiltExercise { get; private set; }

        public ExerciseBuilder()
            : this(new StrengthExercise("Exercise", 3, 10, 0))
        {
        }

        public ExerciseBuilder(
            Exercise exercise,
            bool editing = false)
        {
            InitializeComponent();
            SetupResponsiveLayout();

            template = WorkoutService.CloneExercise(exercise);

            Text = (editing
                ? "Edit Exercise: "
                : "Add Exercise: ") + template.name;

            button1.Text = editing ? "Save" : "Add";

            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            button2.Click -= button2_Click;
            button2.Click += button2_Click;

            AcceptButton = button1;

            if (template is StrengthExercise strength)
            {
                label1.Text = "Weight (kg)";

                textBox1.Text =
                    strength.targetedSets.ToString();

                textBox2.Text =
                    strength.targetedReps.ToString();

                textBox3.Text =
                    strength.targetedWeight.ToString(
                        "0.##",
                        CultureInfo.CurrentCulture);
            }
            else if (template is TimedExercise timed)
            {
                int seconds = (int)Math.Clamp(
                    timed.targetedTime.TotalSeconds,
                    1,
                    86400);

                label3.Text = "Minutes";
                label2.Text = "Seconds";

                textBox1.Text =
                    (seconds / 60).ToString();

                textBox2.Text =
                    (seconds % 60).ToString();

                textBox3.Visible = false;
                label1.Visible = false;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void SetupResponsiveLayout()
        {
            SuspendLayout();

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 6,
                Padding = new Padding(24)
            };

            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 0F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 20F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 90F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 10F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 58F));

            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 20F));

            TableLayoutPanel inputLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 2,
                Margin = Padding.Empty
            };

            inputLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 33.33F));

            inputLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 33.33F));

            inputLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 33.34F));

            inputLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 40F));

            inputLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 60F));

            label3.Dock = DockStyle.Fill;
            label2.Dock = DockStyle.Fill;
            label1.Dock = DockStyle.Fill;

            label3.TextAlign =
                ContentAlignment.BottomCenter;

            label2.TextAlign =
                ContentAlignment.BottomCenter;

            label1.TextAlign =
                ContentAlignment.BottomCenter;

            textBox1.Dock = DockStyle.Fill;
            textBox2.Dock = DockStyle.Fill;
            textBox3.Dock = DockStyle.Fill;

            textBox1.Margin =
                new Padding(12, 5, 12, 5);

            textBox2.Margin =
                new Padding(12, 5, 12, 5);

            textBox3.Margin =
                new Padding(12, 5, 12, 5);

            inputLayout.Controls.Add(label3, 0, 0);
            inputLayout.Controls.Add(label2, 1, 0);
            inputLayout.Controls.Add(label1, 2, 0);

            inputLayout.Controls.Add(textBox1, 0, 1);
            inputLayout.Controls.Add(textBox2, 1, 1);
            inputLayout.Controls.Add(textBox3, 2, 1);

            TableLayoutPanel buttonLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                Margin = Padding.Empty
            };

            buttonLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            buttonLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            buttonLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            buttonLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            buttonLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            button1.Dock = DockStyle.Fill;
            button2.Dock = DockStyle.Fill;

            button1.Margin = new Padding(8);
            button2.Margin = new Padding(8);

            button1.TextAlign =
                ContentAlignment.MiddleCenter;

            button2.TextAlign =
                ContentAlignment.MiddleCenter;

            buttonLayout.Controls.Add(button1, 1, 0);
            buttonLayout.Controls.Add(button2, 2, 0);

            menuBar1.Visible = false;

            Controls.Clear();

            mainLayout.Controls.Add(menuBar1, 0, 0);
            mainLayout.Controls.Add(inputLayout, 0, 2);
            mainLayout.Controls.Add(buttonLayout, 0, 4);

            Controls.Add(mainLayout);

            MinimumSize = new Size(600, 350);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = false;

            ResumeLayout(true);
        }

        private void ExerciseBuilder_Load(
            object? sender,
            EventArgs e)
        {
        }

        private void button1_Click(
            object? sender,
            EventArgs e)
        {
            if (template is StrengthExercise)
            {
                if (!int.TryParse(
                        textBox1.Text,
                        out int sets)
                    || sets < 1
                    || sets > 100)
                {
                    ShowInputError(
                        textBox1,
                        "Enter a whole number of sets between 1 and 100.");

                    return;
                }

                if (!int.TryParse(
                        textBox2.Text,
                        out int reps)
                    || reps < 1
                    || reps > 1000)
                {
                    ShowInputError(
                        textBox2,
                        "Enter a whole number of reps between 1 and 1000.");

                    return;
                }

                if (!double.TryParse(
                        textBox3.Text,
                        NumberStyles.Float,
                        CultureInfo.CurrentCulture,
                        out double weight)
                    || !double.IsFinite(weight)
                    || weight < 0
                    || weight > 1000)
                {
                    ShowInputError(
                        textBox3,
                        "Enter a weight between 0 and 1000 kg. "
                        + "Use 0 for bodyweight exercises.");

                    return;
                }

                BuiltExercise =
                    new StrengthExercise(
                        template.name,
                        sets,
                        reps,
                        weight);
            }
            else if (template is TimedExercise)
            {
                if (!int.TryParse(
                        textBox1.Text,
                        out int minutes)
                    || minutes < 0
                    || minutes > 1440)
                {
                    ShowInputError(
                        textBox1,
                        "Enter whole minutes between 0 and 1440.");

                    return;
                }

                if (!int.TryParse(
                        textBox2.Text,
                        out int seconds)
                    || seconds < 0
                    || seconds > 59)
                {
                    ShowInputError(
                        textBox2,
                        "Enter whole seconds between 0 and 59.");

                    return;
                }

                int totalSeconds =
                    minutes * 60 + seconds;

                if (totalSeconds < 1
                    || totalSeconds > 86400)
                {
                    ShowInputError(
                        textBox1,
                        "Duration must be between 1 second and 24 hours.");

                    return;
                }

                BuiltExercise =
                    new TimedExercise(
                        template.name,
                        TimeSpan.FromSeconds(
                            totalSeconds));
            }
            else
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShowInputError(
            TextBox input,
            string message)
        {
            MessageBox.Show(
                this,
                message,
                "Invalid input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            input.Focus();
            input.SelectAll();
        }

        private void button2_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}