using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    // A collection of exercises, created by the user and categorised into leg day, pull day, etc
    public class Workout
    {
        public string name { get; set; }
        public List<Exercise> exercises { get; set; }

        public Workout(string n) 
        {
            exercises = new List<Exercise>();
            name = n;
        }
    }
}
