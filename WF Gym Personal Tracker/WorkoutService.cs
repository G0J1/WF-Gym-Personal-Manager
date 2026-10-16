using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Gym_Personal_Tracker.Models;
using WF_Gym_Personal_Tracker.Models.Logs;

namespace WF_Gym_Personal_Tracker
{
    public static class WorkoutService
    {
        private static List<Workout> workouts = new List<Workout>();
        private static List<Exercise> exercises = new List<Exercise>();
        private static List<WorkoutLog> workoutLogs = new List<WorkoutLog>();

        public static WorkoutLog activeWorkoutLog;

        public static int currentDashboardWIndex { get; set; } = 0;

        public static int maxIndex => workouts.Count - 1;

        public static DateOnly activeDate;

        static WorkoutService()
        {
            CreateDefaultWorkouts();

            activeDate = DateOnly.FromDateTime(DateTime.Now);

            // Separate live workouts from each other and from catalog templates.
            foreach (Workout workout in workouts)
            {
                workout.exercises = workout.exercises.Select(CloneExercise).ToList();
            }

            // Keep the existing default workouts; offer additional library choices.
            exercises.Add(new StrengthExercise("Hammer Curls", 3, 10, 0));
            exercises.Add(new StrengthExercise("Tricep Extensions", 3, 10, 0));
            exercises.Add(new StrengthExercise("Shoulder Press", 3, 10, 0));
            exercises.Add(new StrengthExercise("Lateral Raises", 3, 10, 0));
            exercises.Add(new StrengthExercise("Calf Raises", 3, 12, 0));
            exercises.Add(new StrengthExercise("Leg Press", 3, 10, 0));
            exercises.Add(new StrengthExercise("Hamstring Curls", 3, 10, 0));
            exercises.Add(new StrengthExercise("Step Ups", 3, 10, 0));
            exercises.Add(new TimedExercise("Plank", TimeSpan.FromSeconds(30)));
        }

        private static readonly HashSet<string> upperBodyNames = new HashSet<string>(
            new[] { "Push Ups", "Pull Ups", "Bicep Curls", "Bench", "Skull Crushers",
                "Hammer Curls", "Tricep Extensions", "Shoulder Press", "Lateral Raises",
                "Dead Hang" }, StringComparer.OrdinalIgnoreCase);

        private static readonly HashSet<string> lowerBodyNames = new HashSet<string>(
            new[] { "Weighted Squats", "Forward Lunges", "Side Lunges",
                "Bulgarian Squats", "Dead Lift", "Calf Raises", "Leg Press",
                "Hamstring Curls", "Step Ups" }, StringComparer.OrdinalIgnoreCase);

        public static List<Exercise> GetAvailableExercises(int workoutIndex)
        {
            ValidateWorkoutIndex(workoutIndex);
            // Lambda filtering gives each day its appropriate library.
            return exercises.Where(exercise => workoutIndex == 2 ||
                    (workoutIndex == 0 && upperBodyNames.Contains(exercise.name)) ||
                    (workoutIndex == 1 && lowerBodyNames.Contains(exercise.name)))
                .OrderBy(exercise => exercise.name)
                .Select(CloneExercise)
                .ToList();
        }

        public static Exercise CloneExercise(Exercise exercise)
        {
            if (exercise is StrengthExercise strength)
                return new StrengthExercise(strength.name, strength.targetedSets,
                    strength.targetedReps, strength.targetedWeight);
            if (exercise is TimedExercise timed)
                return new TimedExercise(timed.name, timed.targetedTime);
            if (exercise is CardioExercise cardio)
                return new CardioExercise(cardio.name)
                {
                    targetedDistance = cardio.targetedDistance,
                    targetedTime = cardio.targetedTime
                };
            throw new ArgumentException("Unsupported exercise type.");
        }

        public static void SaveWorkoutExercises(int workoutIndex, IEnumerable<Exercise> chosenExercises)
        {
            ValidateWorkoutIndex(workoutIndex);
            if (chosenExercises == null)
                throw new ArgumentException("Select exercises before saving.");

            List<Exercise> chosen = chosenExercises.ToList();
            if (chosen.Count == 0)
                throw new ArgumentException("Keep at least one exercise in your workout.");

            HashSet<string> allowedNames = new HashSet<string>(
                GetAvailableExercises(workoutIndex).Select(exercise => exercise.name),
                StringComparer.OrdinalIgnoreCase);
            HashSet<string> selectedNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Validate everything before replacing the live workout.
            foreach (Exercise exercise in chosen)
            {
                if (exercise == null || !allowedNames.Contains(exercise.name))
                    throw new ArgumentException("Choose an exercise from this day's library.");
                if (!selectedNames.Add(exercise.name))
                    throw new ArgumentException("The workout cannot contain duplicate exercises.");

                if (exercise is StrengthExercise strength)
                {
                    if (strength.targetedSets < 1 || strength.targetedSets > 100 ||
                        strength.targetedReps < 1 || strength.targetedReps > 1000 ||
                        !double.IsFinite(strength.targetedWeight) ||
                        strength.targetedWeight < 0 || strength.targetedWeight > 1000)
                        throw new ArgumentException("Use 1-100 sets, 1-1000 reps and 0-1000 kg.");
                }
                else if (exercise is TimedExercise timed)
                {
                    if (timed.targetedTime < TimeSpan.FromSeconds(1) ||
                        timed.targetedTime > TimeSpan.FromHours(24))
                        throw new ArgumentException("Duration must be between 1 second and 24 hours.");
                }
                else
                    throw new ArgumentException("This builder supports strength and timed exercises.");
            }

            workouts[workoutIndex].exercises = chosen.Select(CloneExercise).ToList();
        }

        private static void ValidateWorkoutIndex(int index)
        {
            if (index < 0 || index >= workouts.Count)
                throw new ArgumentException("Select a valid workout day.");
        }


        private static void CreateDefaultWorkouts()
        {

            Workout armDay = new Workout("Arm Day");
            StrengthExercise pushUp = new StrengthExercise("Push Ups", 3, 3, 20.0f);
            StrengthExercise pullUp = new StrengthExercise("Pull Ups", 3, 3, 20.0f);
            StrengthExercise bicepCurls = new StrengthExercise("Bicep Curls", 3, 3, 20.0f);
            StrengthExercise bench = new StrengthExercise("Bench", 3, 3, 20.0f);
            StrengthExercise skullCrushes = new StrengthExercise("Skull Crushers", 3, 3, 20.0f);
            armDay.exercises.Add(pushUp);
            armDay.exercises.Add(pullUp);
            armDay.exercises.Add(bicepCurls);
            armDay.exercises.Add(bench);
            armDay.exercises.Add(skullCrushes);


            Workout legDay = new Workout("Leg Day");
            StrengthExercise squat = new StrengthExercise("Weighted Squats", 3, 3, 20.0f);
            StrengthExercise forLunge = new StrengthExercise("Forward Lunges", 3, 3, 20.0f);
            StrengthExercise sideLunge = new StrengthExercise("Side Lunges", 3, 3, 20.0f);
            StrengthExercise bulgSquats = new StrengthExercise("Bulgarian Squats", 3, 3, 20.0f);
            StrengthExercise deadLift = new StrengthExercise("Dead Lift", 3, 3, 20.0f);
            legDay.exercises.Add(squat);
            legDay.exercises.Add(forLunge);
            legDay.exercises.Add(sideLunge);
            legDay.exercises.Add(bulgSquats);
            legDay.exercises.Add(deadLift);


            TimedExercise deadHang = new TimedExercise("Dead Hang", new TimeSpan(0, 1, 0));

            exercises.Add(pushUp);
            exercises.Add(pullUp);
            exercises.Add(bicepCurls);
            exercises.Add(bench);
            exercises.Add(skullCrushes);
            exercises.Add(squat);
            exercises.Add(forLunge);
            exercises.Add(sideLunge);
            exercises.Add(bulgSquats);
            exercises.Add(deadLift);
            exercises.Add(deadHang);

            Workout fullBody = new Workout("Full Body Day");
            foreach (Exercise e in exercises)
            {
                fullBody.exercises.Add(e);
            }

            workouts.Add(armDay);
            workouts.Add(legDay);
            workouts.Add(fullBody);

        }

        public static List<Workout> GetWorkouts()
        {
            return workouts;
        }

        public static string GetWorkoutName(int index)
        {
            if (workouts[index] != null)
            {
                return workouts[index].name;
            }


            return "0";
        }

        public static List<Exercise> GetExercises(int index)
        {
            return workouts[index].exercises;
        }

        public static List<WorkoutLog> GetWorkoutLogs()
        {
            return workoutLogs;
        }

        public static void AddWorkLog(WorkoutLog log)
        {
            workoutLogs.Add(log);
        }

        public static bool IsWorkoutCompleted()
        {
            return workoutLogs
                    .Where(w => w.completionDate == activeDate)
                    .Any(w => w.completed);
        }

        public static void StartActiveWorkout(Workout w)
        {
            activeWorkoutLog = new WorkoutLog(w);
        }

        public static void FinishActiveWorkout()
        {
            if (activeWorkoutLog == null)
            {
                return;
            }
            activeWorkoutLog.completed = true;
            activeWorkoutLog.completionDate = activeDate;
            AddWorkLog(activeWorkoutLog);
            activeWorkoutLog = null;
        }

        public static bool IsWorkoutActive()
        {
            return activeWorkoutLog != null;
        }

        public static void SetActiveDate(DateOnly date)
        {
            activeDate = date;

            /*MessageBox.Show(activeDate.ToLongDateString());*/
            if (IsWorkoutCompleted())
            {
                WorkoutLog completedLog = workoutLogs.FirstOrDefault(w => w.completionDate == activeDate);
                currentDashboardWIndex = workouts.FindLastIndex(w => w.name == completedLog.workout.name);
            }
        }
    }
}