using System;
using System.Collections;
using System.Collections.Generic;
using Scriptable_Object_Scripts;
using UnityEngine;
using SimpleSQL;

public class History
{
    [PrimaryKey] public string DateTime { get; set; }
    [PrimaryKey] public string WorkoutName { get; set; }
    [PrimaryKey] public string ExerciseName { get; set; }
    public ExerciseType ExerciseType { get; set; }
    public SetType SetType { get; set; }
    [PrimaryKey] public int SetNumber { get; set; }
    public float SetWeight { get; set; }
    public int SetRepetitions { get; set; }
}
