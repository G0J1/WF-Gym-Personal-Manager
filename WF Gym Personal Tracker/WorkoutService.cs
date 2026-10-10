using System;
using System.Collections.Generic;
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
        private static List<WorkoutLog> workoutLogs = new List<WorkoutLog>();

        public static int maxIndex => workouts.Count - 1;

        static WorkoutService()
        {
            CreateDefaultWorkouts();
        }


        private static void CreateDefaultWorkouts()
        {

            Workout armDay = new Workout("Arm Day");
            StrengthExercise pushUp = new StrengthExercise("Push Ups", 3, 3, 20.0f);
            StrengthExercise pullUp = new StrengthExercise("Pull Ups", 3, 3, 20.0f);
            armDay.exercises.Add(pushUp);
            armDay.exercises.Add(pullUp);

            Workout legDay = new Workout("Leg Day");
            StrengthExercise squat = new StrengthExercise("Weighted Squats", 3, 3, 20.0f);
            StrengthExercise forLunge = new StrengthExercise("Forward Lunges", 3, 3, 20.0f);
            legDay.exercises.Add(squat);
            legDay.exercises.Add(forLunge);

            Workout fullBody = new Workout("Full Body Day");
            fullBody.exercises.Add(pushUp);
            fullBody.exercises.Add(squat);

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

    }
}
