using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models.Logs
{
    public class ExerciseLog
    {
        public Exercise loggedExercise { get; set; }

        public int recordedReps { get; set; }
        public int recordedSets { get; set; }
        public double recordedWeight { get; set; }
        public TimeSpan recordedTime { get; set; }
    }
}
