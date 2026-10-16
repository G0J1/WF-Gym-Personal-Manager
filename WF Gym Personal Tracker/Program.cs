using WF_Gym_Personal_Tracker.Database;
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

            // Creates SQLite database if it doesnt exist yet
            using (var db = new WorkoutDbContext())
            {
                db.Database.EnsureCreated();
            }

            // starts the application
            Application.Run(new Dashboard());

            // temp db test
            //WorkoutDbContext.TestDatabaseModel();
        }
    }
}