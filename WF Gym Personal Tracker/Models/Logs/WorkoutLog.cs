using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models.Logs
{
    public class WorkoutLog
    {
        public Workout workout { get; set; }
        public List<ExerciseLog> exerciseLogs { get; set; }
        public bool completed { get; set; }
        public DateOnly completionDate { get; set; }

        public WorkoutLog() 
        {
            exerciseLogs = new List<ExerciseLog>();
        }
        
    }
}
