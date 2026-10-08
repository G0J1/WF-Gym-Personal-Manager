using WF_Gym_Personal_Tracker.Models;

namespace WF_Gym_Personal_Tracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());

            List<Workout> workouts = new List<Workout>();

            Workout armDay = new Workout("Arm Day");
            StrengthExercise pushUp = new StrengthExercise("Push Ups", 3, 3, 20.0f);
            StrengthExercise pullUp = new StrengthExercise("Pull Ups", 3, 3, 20.0f);
            armDay.exercises.Add(pushUp);
            armDay.exercises.Add(pullUp);

            Workout legDay = new Workout("Leg Day");
            StrengthExercise squat = new StrengthExercise("Weighted Squats", 3, 3, 20.0f);
            StrengthExercise forLunge = new StrengthExercise("Forward Lunges", 3, 3, 20.0f);
            armDay.exercises.Add(squat);
            armDay.exercises.Add(forLunge);

            Workout fullBody = new Workout("Full Body Day");
            fullBody.exercises.Add(pushUp);
            fullBody.exercises.Add(pullUp);

            workouts.Add(armDay);
            workouts.Add(legDay);
            workouts.Add(fullBody);

        }
    }
}