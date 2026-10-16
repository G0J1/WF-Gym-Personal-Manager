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
        public DbSet<WorkoutLog> WorkoutLogs => Set<WorkoutLog>();
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

            db.WorkoutLogs.Add(log);
            db.SaveChanges();
        }

        public static List<WorkoutLog> GetWorkoutLogs()
        {
            using var db = new WorkoutDbContext();

            return db.WorkoutLogs
                .Include(w => w.workout)
                .Include(w => w.exerciseLogs)
                    .ThenInclude(e => e.loggedExercise)
                .AsNoTracking()
                .ToList();
        }

        // creating the db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // workout
            modelBuilder.Entity<Workout>(entity =>
            {
                entity.HasKey(w => w.WorkoutId);

                entity.Property(w => w.name)
                    .IsRequired();


                // one to many relationship
                // one workout contains many exercises
                entity.HasMany(w => w.exercises)
                    .WithOne()
                    .HasForeignKey("WorkoutId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // exercise inheritance
            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.HasKey(e => e.ExerciseId);

                entity.Property(e => e.name)
                    .IsRequired();

                // store exercise subclasses in one table
                entity.HasDiscriminator<string>("ExerciseType")
                      .HasValue<StrengthExercise>("Strength")
                      .HasValue<TimedExercise>("Timed")
                      .HasValue<CardioExercise>("Cardio");

            });

            // workout log
            modelBuilder.Entity<WorkoutLog>(entity =>
            {
                entity.HasKey(w => w.WorkoutLogId);

                entity.HasOne(w => w.workout)
                       .WithMany()
                       .HasForeignKey(w => w.WorkoutId)
                       .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(w => w.exerciseLogs)
                      .WithOne(e => e.WorkoutLog)
                      .HasForeignKey(e => e.WorkoutLogId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // exercise log
            modelBuilder.Entity<ExerciseLog>(entity =>
            {
                entity.HasKey(e => e.ExerciseLogId);

                entity.HasOne(e => e.loggedExercise)
                      .WithMany()
                      .HasForeignKey(e => e.ExerciseId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }

        // temporary test
        public static void TestDatabaseModel()
        {
            try
            {
                using var db = new WorkoutDbContext();

                var model = db.Model;

                MessageBox.Show(
                    "EFC model loaded successfully.",
                    "Database Validation.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }

}

