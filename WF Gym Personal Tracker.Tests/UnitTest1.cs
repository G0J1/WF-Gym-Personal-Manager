using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WF_Gym_Personal_Tracker.Models;

namespace WF_Gym_Personal_Tracker.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class WorkoutServiceTests
    {
        private List<Exercise> originalArmExercises = null!;

        [SetUp]
        public void SetUp()
        {
            originalArmExercises = WorkoutService.GetExercises(0)
                .Select(WorkoutService.CloneExercise)
                .ToList();
        }

        [TearDown]
        public void TearDown()
        {
            WorkoutService.SaveWorkoutExercises(0, originalArmExercises);
        }

        [Test]
        public void SaveWorkoutExercises_SavesExerciseDetails()
        {
            StrengthExercise selectedExercise =
                new StrengthExercise("Hammer Curls", 4, 12, 17.5);

            WorkoutService.SaveWorkoutExercises(
                0,
                new[] { selectedExercise });

            List<Exercise> savedExercises =
                WorkoutService.GetExercises(0);

            Assert.That(savedExercises, Has.Count.EqualTo(1));

            StrengthExercise savedExercise =
                (StrengthExercise)savedExercises[0];

            Assert.Multiple(() =>
            {
                Assert.That(savedExercise.name,
                    Is.EqualTo("Hammer Curls"));

                Assert.That(savedExercise.targetedSets,
                    Is.EqualTo(4));

                Assert.That(savedExercise.targetedReps,
                    Is.EqualTo(12));

                Assert.That(savedExercise.targetedWeight,
                    Is.EqualTo(17.5));
            });
        }
    }
}