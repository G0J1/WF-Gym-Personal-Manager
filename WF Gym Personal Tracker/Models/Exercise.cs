using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    // An exercise the user will perform and record, has reps, sets, weights and time (if applicable)

    public abstract class Exercise
    {
        public string name { get; set; }
    }
}
