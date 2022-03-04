using System;
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
    
    [Serializable]
    public class ExerciseObject
    {
        public int _ExerciseID;
        public string _ExerciseName;
        
        public BodyPart _BodyPart;
        
        public ExerciseType _ExerciseType;
        
        public int _WarmUpRestTimer;
        
        public int _RealRestTimer;

        public SetObject[] sets;

    }
}


