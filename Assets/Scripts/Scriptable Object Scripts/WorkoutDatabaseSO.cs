using System;
using System.Collections;
using System.Collections.Generic;
using Scriptable_Object_Scripts;
using UnityEngine;

namespace Scriptable_Object_Scripts
{
    [CreateAssetMenu(fileName = "Workout Database Name", menuName = "Workforce/Workout Database", order = 2)]
    public class WorkoutDatabaseSO : ScriptableObject
    {
        public List<WorkoutObject> _Workouts;
    }
}

