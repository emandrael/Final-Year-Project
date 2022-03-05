using System;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;

namespace Scriptable_Object_Scripts
{
    [CreateAssetMenu(fileName = "Workout Name", menuName = "Workforce/Workout", order = 1)]

    public class WorkoutSO : ScriptableObject
    {
        public WorkoutObject workout;

        public string GetWorkoutName()
        {
            return workout._WorkoutName;
        }

        public void InsertWorkoutHistory(SimpleSQLManager manager)
        {
            const string sql = "INSERT INTO History " +
                               "(\"Date Time\", \"Workout Name\", \"Exercise Name\", \"Exercise Type\", \"Set Number\", \"Set Type\", \"Set Weight\", \"Set Repetitions\") " +
                               "VALUES (?,?,?,?,?,?,?,?)";
            foreach (var exercise in workout._Exercises)
            {
                for (int i = 0; i < exercise._Sets.Count; i++)
                {
                    SetDatabaseObject insertValue = new SetDatabaseObject()
                    {
                        DateTime = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"),
                        WorkoutName = workout._WorkoutName,
                        ExerciseName = exercise._ExerciseName,
                        ExerciseType = exercise._ExerciseType,
                        SetNumber = i + 1,
                        SetType = exercise._Sets[i]._SetType,
                        SetWeight = exercise._Sets[i]._Weight,
                        SetRepetitions = exercise._Sets[i]._Reps
                    };
                    
                    manager.Execute
                    (
                        sql,
                        insertValue.DateTime,
                        insertValue.WorkoutName,
                        insertValue.ExerciseName,
                        insertValue.ExerciseType,
                        insertValue.SetNumber,
                        insertValue.SetType,
                        insertValue.SetWeight,
                        insertValue.SetRepetitions
                    );
                }
            }
        }
        
    }
}
