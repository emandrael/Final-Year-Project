using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Workout Name", menuName = "Workforce/Workout", order = 1)]
public class WorkoutSO : ScriptableObject
{
    public string workoutName;
    public ExerciseSO[] exercises;
}
