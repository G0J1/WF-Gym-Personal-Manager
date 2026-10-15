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


        public Workout workout;

        public DashboardRow(Exercise e, Workout wrk)
        {
            name = e.name;
            workout = wrk;
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
            if (WorkoutService.IsWorkoutActive())
            {
                return WorkoutService.activeWorkoutLog.exerciseLogs
                    .Any(eL => eL.loggedExercise.name == name && eL.completed);
            }

            return WorkoutService.GetWorkoutLogs()
                            .Where(w => w.completed && w.workout.name == workout.name && w.completionDate == FormControls.GetTodaysDate())
                            .SelectMany(w => w.exerciseLogs)
                            .Any(eL => eL.loggedExercise.name == name && eL.completed);
        }
    }
}
