using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Gym_Personal_Tracker.Models;

namespace WF_Gym_Personal_Tracker
{
    public class DashboardRow
    {
        public string name { get; set; }
        public int sets { get; set; }
        public int reps { get; set; }
        public double weight { get; set; }
        public TimeSpan duration { get; set; }
        public bool completed { get; set; }

        public int workoutIndex;

        public DashboardRow(Exercise e, int w)
        {
            name = e.name;
            workoutIndex = w;
            if (e is StrengthExercise)
            {
                StrengthExercise se = (StrengthExercise)e;
                sets = se.targetedSets;
                reps = se.targetedReps;
                weight = se.targetedWeight;

            }
            else if (e is TimedExercise)
            {
                TimedExercise te = (TimedExercise)e;
                duration = te.targetedTime;
                completed = false;

            }
            completed = refreshCompleted();
        }

        public bool refreshCompleted()
        {
            if (workoutIndex < 0 || workoutIndex >= WorkoutService.GetWorkoutLogs().Count)
            {
                return false;
            }

            return WorkoutService.GetWorkoutLogs()[workoutIndex].exerciseLogs
                            .Where(eL => eL.loggedExercise.name == name)
                            .Select(eL => eL.completed)
                            .FirstOrDefault();
        }
    }
}
