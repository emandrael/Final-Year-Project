using UnityEngine;

namespace Scriptable_Object_Scripts
{
    [CreateAssetMenu(fileName = "Workout Name", menuName = "Workforce/Workout", order = 1)]



    public class WorkoutSO : ScriptableObject
    {
        public string _WorkoutName;
        public ExerciseObject[] _Exercises;
    }
}
