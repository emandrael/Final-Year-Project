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
        public WorkoutSO WorkoutSO;
        [SerializeField] private SimpleSQLManager SQLManager;

        public void Start()
        {
            //WorkoutSO.InsertWorkoutHistory(SQLManager);

            string sql = "SELECT * FROM History";

            List<History> histories = SQLManager.Query<History>(sql);
            
            foreach (History set in histories)
            {
                Debug.Log(set.ExerciseName);
            }
        }
    }
}
