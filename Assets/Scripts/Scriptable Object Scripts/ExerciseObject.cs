namespace WorkoutEngine
{
    public enum ExerciseType
    {
        Back,
        Chest,
        Arms,
        Legs,
        Other
    }
    [System.Serializable]
    public class ExerciseObject
    {
        public string _ExerciseName;
        public ExerciseType _ExerciseType;
        public SetObject[] _Sets;
    }
}


