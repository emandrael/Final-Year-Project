using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseScripts;
using Scriptable_Object_Scripts;
using SimpleSQL;
using TigerForge;
using UnityEngine;

namespace WorkoutMenu
{
    public class WorkoutDatabase : MonoBehaviour
    {
        public List<WorkoutObject> _WorkoutDatabase;

        [SerializeField] private SimpleSQLManager _SqlManager;

        [SerializeField] private WorkoutDatabaseButton _ButtonPrefab;

        [SerializeField] private Transform _ScrollView;

        [SerializeField] private WorkoutObject selectedWorkoutObject;
        
        

        private void Start()
        {
            _WorkoutDatabase = GetWorkouts();
            
            foreach (var workout in _WorkoutDatabase)
            {
                var workoutButton = Instantiate(_ButtonPrefab,_ScrollView);
                workoutButton.SetButton(workout._WorkoutName, workout);
            }
            
            EventManager.StartListening(EventConstants.CHECK_WORKOUT,SetSelectedObject);
        }

        private void SetSelectedObject()
        {
            selectedWorkoutObject = (WorkoutObject) EventManager.GetData(EventConstants.CHECK_WORKOUT);
        }


        private List<WorkoutObject> GetWorkouts()
        {
            var workouts = new List<WorkoutObject>();
            
            const string sql = "SELECT * FROM Workouts";
            
            var databaseObjects = _SqlManager.Query<WorkoutsDatabaseObject>(sql);
            
            
            foreach (var workout in databaseObjects)
            {
                var workoutObject = new WorkoutObject(workout.WorkoutName, GetExercises(workout.WorkoutExercises));
                workouts.Add(workoutObject);
            }

            return workouts;
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
                databaseRecord.GetSets()
            );
        }
        
        public List<SetObject> GetSetsFromString(string setExerciseHistory)
        {
            var sets = new List<SetObject>();
            
            var setsSplitString = setExerciseHistory.Split(";");

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

        private List<ExerciseObject> GetExercises(string exerciseString)
        {
            var idListSplit = exerciseString.Split(",");

            var exercises = new List<ExerciseObject>();

            foreach (var id in idListSplit)
            {
                exercises.Add(GetExerciseWithID(int.Parse(id)));
            }

            return exercises;
        }
    }
}
