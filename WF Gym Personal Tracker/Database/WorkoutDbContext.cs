using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WF_Gym_Personal_Tracker.Database;
using WF_Gym_Personal_Tracker.Models;
using WF_Gym_Personal_Tracker.Models.Logs;

namespace WF_Gym_Personal_Tracker.Database
{
    public class WorkoutDbContext : DbContext
    {
        public DbSet<Workout> Workouts => Set<Workout>();
        public DbSet<Exercise> Exercises => Set<Exercise>();
        public DbSet<WorkoutLog> Workoutlogs => Set<WorkoutLog>();
        public DbSet<ExerciseLog> ExerciseLogs => Set<ExerciseLog>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PersonalWorkoutTracker");

            Directory.CreateDirectory(folder);

            string databasePath = Path.Combine(folder, "workouts.db");

            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        // not yet implemented, just base for later on
        // if implementing the models have to be persist

        // change the variable names with database id

        // public int WorkoutLogID { get; set; }
        // public int WorkoutID { get; set; }
        // public int ExerciseLogID { get; set; }
        // public int WorkoutLogId { get; set; }
        // public int ExerciseId { get; set; }

        public static void AddWorkLog(WorkoutLog log)
        {
            using var db = new WorkoutDbContext();

            db.Workoutlogs.Add(log);
            db.SaveChanges();
        }

        public static List<WorkoutLog> GetWorkoutLogs()
        {
            using var db = new WorkoutDbContext();

            return db.Workoutlogs
                .Include(w => w.workout)
                .Include(w => w.exerciseLogs)
                    .ThenInclude(e => e.loggedExercise)
                .AsNoTracking()
                .ToList();
        }

    }

}

