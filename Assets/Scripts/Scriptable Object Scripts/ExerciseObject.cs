namespace Scriptable_Object_Scripts
{
    public enum BodyPart
    {
        Back,
        Chest,
        Arms,
        Legs,
        Other
    }

    public enum ExerciseType
    {
        Barbell,
        Dumbbell,
        MachineOther,
        WeightedBodyWeight,
        AssistedBodyWeight,
        RepsOnly
    }

    public enum RestTimer
    {
        Null,
        OneMin,
        TwoMin,
        ThreeMin,
    }

    [System.Serializable]
    public class ExerciseObject
    {
        public string _ExerciseName;
        public BodyPart _BodyPart;
        public ExerciseType _ExerciseType;
        public RestTimer _WarmUpRestTimer;
        public RestTimer _RealRestTimer;
        public SetObject[] Sets;
    }
}


