using System.Collections.Generic;
using System.Linq;
using Scriptable_Object_Scripts;
using SimpleSQL;
using UnityEngine;

namespace DatabaseScripts
{
    public class ExerciseDatabaseObject
    {
        [PrimaryKey, AutoIncrement] public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        public BodyPart BodyPart { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public int WarmUpRestTimer { get; set; }
        public int RealRestTimer { get; set; }
        public string Sets { get; set; }


        public ExerciseDatabaseObject() {}

        public ExerciseDatabaseObject(ExerciseObject exerciseObject)
        {
            ExerciseID = exerciseObject._ExerciseID;
            ExerciseName = exerciseObject._ExerciseName;
            BodyPart = exerciseObject._BodyPart;
            ExerciseType = exerciseObject._ExerciseType;
            WarmUpRestTimer = exerciseObject._WarmUpRestTimer;
            RealRestTimer = exerciseObject._RealRestTimer;

            var sets = exerciseObject._Sets;
            var setString = "";

            for (int i = 0; i < sets.Count - 1; i++)
            {
                setString += (int) sets[i]._SetType + "," + (float)sets[i]._Weight + "," + sets[i]._Reps + ";";
            }

            setString += (int) sets[^1]._SetType + "," + sets[^1]._Weight + "," +
                         sets[^1]._Reps;

            Debug.Log(setString);
            
            Sets = setString;


        }

        public List<SetObject> GetSets()
        {
            var sets = new List<SetObject>();
            
            var setsSplitString = Sets.Split(";");

            foreach (var set in setsSplitString)
            {
                var setSplitString = set.Split(",");
                var setType = (SetType) int.Parse(setSplitString[0]);
                var weight = float.Parse(setSplitString[1]);
                var reps = int.Parse(setSplitString[2]);

                sets.Add(new SetObject(setType,weight,reps));
            }

            return sets;

        }
    }
}
