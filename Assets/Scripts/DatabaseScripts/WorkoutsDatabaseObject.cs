using System.Collections.Generic;
using Scriptable_Object_Scripts;
using SimpleSQL;
namespace DatabaseScripts
{
    public class WorkoutsDatabaseObject
    {
        [PrimaryKey] public int WorkoutID { get; set; }
        public string WorkoutName { get; set; }
        public string WorkoutExercises { get; set; }
        
        public string LastWorkout { get; set; }
        
    }
}
