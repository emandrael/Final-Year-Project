using System;
using System.Collections.Generic;
using Scriptable_Object_Scripts;
using UnityEngine;
using Doozy.Runtime.UIManager;
using Doozy.Runtime.UIManager.Components;
using SimpleSQL;

namespace Workout_Database_Scripts
{
    public class WorkoutDatabase : MonoBehaviour
    {
        public WorkoutObject WorkoutObject;
        [SerializeField] private SimpleSQLManager SQLManager;

        public void Start()
        {
            WorkoutObject = new WorkoutObject();
            
            string sql = "SELECT * FROM Exercises";

            List<ExerciseObject> exerciseObjects = SQLManager.Query<ExerciseObject>(sql);
            
            foreach (ExerciseObject exercise in exerciseObjects)
            {
                Debug.Log(exercise.BodyPart);
            }
        }
    }
}
