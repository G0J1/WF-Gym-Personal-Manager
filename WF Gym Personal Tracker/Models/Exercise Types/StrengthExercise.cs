using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    public class StrengthExercise : Exercise
    {
        public int targetedSets { get; set; }
        public int targetedReps { get; set; }
        public double targetedWeight { get; set; }

        public StrengthExercise(string n, int s, int r, double w) : base(n) 
        {
            targetedReps = r;
            targetedWeight = w;
            targetedSets = s;
        }
    }
}
