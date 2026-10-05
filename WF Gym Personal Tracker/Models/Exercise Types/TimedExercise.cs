using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    public class TimedExercise : Exercise
    {
        public TimeSpan targetedTime { get; set; }
    }
}
