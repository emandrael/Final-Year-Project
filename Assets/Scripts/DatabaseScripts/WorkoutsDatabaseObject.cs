using SimpleSQL;

namespace DatabaseScripts
{
    public class WorkoutsDatabaseObject
    {
        [PrimaryKey] public int WorkoutID { get; set; }
        [PrimaryKey] public string WorkoutName { get; set; } 
        [PrimaryKey] public string WorkoutExercises { get; set; }
        [PrimaryKey] public string LastWorkout { get; set; }
    }
}
