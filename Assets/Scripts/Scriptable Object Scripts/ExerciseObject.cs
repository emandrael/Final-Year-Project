using System;
using System.Collections.Generic;
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
        public List<SetObject> _Sets;

        public ExerciseObject(int exerciseID, string exerciseName, BodyPart bodyPart, ExerciseType exerciseType,
            int warmUpRestTimer, int realRestTimer, List<SetObject> setObjects)
        {
            _ExerciseID = exerciseID;
            _ExerciseName = exerciseName;
            _BodyPart = bodyPart;
            _ExerciseType = exerciseType;
            _WarmUpRestTimer = warmUpRestTimer;
            _RealRestTimer = realRestTimer;
            _Sets = setObjects;
        }

        public void AddSet(SetType setType, float weight, int reps)
        {
            _Sets.Add(new SetObject(setType,weight,reps));
        }

        public void RemoveSet(int index)
        {
            _Sets.RemoveAt(index);
        }
    }

}


