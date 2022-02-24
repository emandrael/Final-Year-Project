using SimpleSQL;

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

    
    public class ExerciseObject
    {
        [NotNull]
        public int ExerciseID { get; set; }
        
        [NotNull]
        public string ExerciseName{ get; set; }
        
        [NotNull]
        public BodyPart BodyPart{ get; set; }
        
        [NotNull]
        public ExerciseType ExerciseType{ get; set; }
        
        [NotNull]
        public RestTimer WarmUpRestTimer{ get; set; }
        
        [NotNull]
        public RestTimer RealRestTimer{ get; set; }
    }
}


