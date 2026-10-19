using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Gym_Personal_Tracker.Forms;

namespace WF_Gym_Personal_Tracker.Models.Logs
{

    public class ExerciseLog
    {

        // pk
        public int ExerciseLogId { get; set; } 

        // fk workout session
        public int WorkoutLogId { get; set; } 

        // navigation property to the workout session
        public WorkoutLog? WorkoutLog { get; set; } 

        //  fk exercise
        public int ExerciseId { get; set; }


        public Exercise loggedExercise { get; set; }

        public int recordedReps { get; set; }
        public int recordedSets { get; set; }
        public double recordedWeight { get; set; }
        public TimeSpan recordedTime { get; set; }
        public bool completed { get; set; }
        public DateOnly completionDate { get; set; }


        public ExerciseLog()
        {
            loggedExercise = null!;
        }

        public ExerciseLog(Exercise exercise)
        {
            loggedExercise = exercise;
            ExerciseId = exercise.ExerciseId;
            completed = false;
        }
    }
}
