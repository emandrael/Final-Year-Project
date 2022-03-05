using System;
using System.Collections.Generic;
using Scriptable_Object_Scripts;
using UnityEngine;

[Serializable]
public class WorkoutObject
{
    public string _WorkoutName;
    public List<ExerciseObject> _Exercises;

    public WorkoutObject(string workoutName, List<ExerciseObject> exercises)
    {
        _WorkoutName = workoutName;
        _Exercises = exercises;
    }

    public void AddExercise(ExerciseObject exerciseObject)
    {
        _Exercises.Add(exerciseObject);
    }

    public void RemoveExerciseAt(int index)
    {
        _Exercises.RemoveAt(index);
    }

    public string GetExerciseOrder()
    {
        var idString = "";
        for (var i = 0; i < _Exercises.Count; i++)
        {
            if (i == (_Exercises.Count - 1))
            {
                idString += _Exercises[i]._ExerciseID;
                break;
            }

            idString += _Exercises[i]._ExerciseID + ",";
        }

        return idString;
    }

    public void SwitchExercisePositions(int positionOne, int positionTwo)
    {
        if (positionOne >= _Exercises.Count || positionTwo >= _Exercises.Count) return;

        var temp = _Exercises[positionOne];
        
        _Exercises[positionOne] = _Exercises[positionTwo];
        _Exercises[positionTwo] = temp;
    }
}


