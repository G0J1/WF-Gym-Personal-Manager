using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    public class CardioExercise : Exercise
    {
        public double targetedDistance { get; set; }
        public TimeSpan targetedTime { get; set; }
    }
}
