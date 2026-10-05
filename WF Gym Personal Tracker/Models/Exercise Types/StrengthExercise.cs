using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    public class StrengthExercise : Exercise
    {
        public int sets { get; set; }
        public int reps { get; set; }
        public double weight { get; set; }
    }
}
