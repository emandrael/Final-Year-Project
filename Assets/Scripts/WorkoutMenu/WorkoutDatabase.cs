using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseScripts;
using Scriptable_Object_Scripts;
using SimpleSQL;
using UnityEngine;

namespace WorkoutMenu
{
    public class WorkoutDatabase : MonoBehaviour
    {
        public List<WorkoutObject> _WorkoutDatabase;

        [SerializeField] private SimpleSQLManager _SqlManager;

        [SerializeField] private WorkoutDatabaseButton _ButtonPrefab;

        [SerializeField] private Transform _ScrollView;
        
        

        private void Start()
        {
            _WorkoutDatabase = GetWorkouts();
            
            foreach (var workout in _WorkoutDatabase)
            {
                var workoutButton = Instantiate(_ButtonPrefab,_ScrollView);
                workoutButton.SetButton(workout._WorkoutName, workout);
            }

            Debug.Log(_WorkoutDatabase[0].GetExerciseOrder());
        }


        private List<WorkoutObject> GetWorkouts()
        {
            var returnList = new List<WorkoutObject>();
            
            const string sql = "SELECT * FROM Workouts";
            
            var databaseObjects = _SqlManager.Query<WorkoutsDatabaseObject>(sql);
            
            foreach (var workout in databaseObjects)
            {
                var workoutObject = new WorkoutObject(workout.WorkoutName, GetExercises(workout.WorkoutExercises));
                returnList.Add(workoutObject);
            }

            return returnList;
        }

        private ExerciseObject GetExerciseWithID(int exerciseID)
        {
            var sql = "SELECT * FROM Exercises WHERE ExerciseID = " + exerciseID;
            var databaseRecord = _SqlManager.QueryFirstRecord<ExerciseDatabaseObject>(out _,sql);
            
            return new ExerciseObject
            (
                databaseRecord.ExerciseID,
                databaseRecord.ExerciseName,
                databaseRecord.BodyPart,
                databaseRecord.ExerciseType,
                databaseRecord.WarmUpRestTimer,
                databaseRecord.RealRestTimer,
                new List<SetObject>()
            );
        }

        private List<ExerciseObject> GetExercises(string exerciseString)
        {
            var idListSplit = exerciseString.Split(",");

            return idListSplit.Select(id => GetExerciseWithID(int.Parse(id))).ToList();
        }
    }
}
