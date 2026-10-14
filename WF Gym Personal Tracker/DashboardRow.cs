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
        public bool completed {  get; set; }

        public DashboardRow(Exercise e)
        {
            name = e.name;
            if (e is StrengthExercise)
            {
                StrengthExercise se = (StrengthExercise)e;
                sets = se.targetedSets;
                reps = se.targetedReps;
                weight = se.targetedWeight;
                completed = false;
            }
            else if (e is TimedExercise)
            {
                TimedExercise te = (TimedExercise)e;
                duration = te.targetedTime;
                completed = false;

            }
        }
    }
}
