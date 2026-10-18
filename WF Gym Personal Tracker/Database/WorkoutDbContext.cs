using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
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
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.SetNull);
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
    }

}

