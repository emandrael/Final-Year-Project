using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ExerciseSO
{
    public string exerciseName;
    public ExerciseSet[] sets;
}
[System.Serializable]
public class ExerciseSet
{
    public float weight;
    public int reps;
}

