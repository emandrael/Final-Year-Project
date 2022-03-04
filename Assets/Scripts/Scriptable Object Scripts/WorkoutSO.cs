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
            foreach (var exercise in workout._Exercises)
            {

                for (int i = 0; i < exercise.sets.Length; i++)
                {
                    History InsertValue = new History()
                    {
                        DateTime = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"),
                        WorkoutName = workout._WorkoutName,
                        ExerciseName = exercise._ExerciseName,
                        ExerciseType = exercise._ExerciseType,
                        SetNumber = i + 1,
                        SetType = exercise.sets[i]._SetType,
                        SetWeight = exercise.sets[i]._Weight,
                        SetRepetitions = exercise.sets[i]._Reps
                    };
                    
                    string sql = "INSERT INTO History " +
                                       "(\"Date Time\", \"Workout Name\", \"Exercise Name\", \"Exercise Type\", \"Set Number\", \"Set Type\", \"Set Weight\", \"Set Repetitions\") " +
                                       "VALUES (?,?,?,?,?,?,?,?)";

                    manager.Execute
                    (
                        sql,
                        InsertValue.DateTime,
                        InsertValue.WorkoutName,
                        InsertValue.ExerciseName,
                        InsertValue.ExerciseType,
                        InsertValue.SetNumber,
                        InsertValue.SetType,
                        InsertValue.SetWeight,
                        InsertValue.SetRepetitions
                    );
                }
            }
        }
        
    }
}
