using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    // An exercise the user will perform and record, have the targeted reps, sets, weights and time (if applicable) - split into subclasses

    public abstract class Exercise
    {
        public string name { get; set; }

        public Exercise(string n)
        {
            name = n;
        }
    }
}
