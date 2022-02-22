using UnityEngine.Events;
using Scriptable_Object_Scripts;
using System;

namespace Workout_Database_Scripts
{
    [Serializable]
    public class WorkoutEvent : UnityEvent<WorkoutSO> {}
}