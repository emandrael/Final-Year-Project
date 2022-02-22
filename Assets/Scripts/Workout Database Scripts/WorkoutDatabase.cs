using Scriptable_Object_Scripts;
using UnityEngine;
using Doozy.Runtime.UIManager;
using Doozy.Runtime.UIManager.Components;

namespace Workout_Database_Scripts
{
    public class WorkoutDatabase : MonoBehaviour
    {
        [SerializeField] private WorkoutSO[] AllWorkouts;

        [SerializeField] private GameObject WorkoutButtonPrefab;
        [SerializeField] private Transform ButtonsParentTransform;

        public WorkoutSO CurrentlyActiveWorkout;

        // Start is called before the first frame update
        void Start()
        {
            foreach (var workout in AllWorkouts)
            {
                GameObject newButton = Instantiate(WorkoutButtonPrefab,ButtonsParentTransform);
                WorkoutDatabaseButton button = newButton.GetComponent<WorkoutDatabaseButton>();
                button._Workout = workout;
                button.AssignWorkout(workout);
            }
        }

        public void ValueChange(Vector2 vector2)
        {
            Debug.Log(vector2);
        }

        public void SelectWorkout(WorkoutSO workout)
        {
            CurrentlyActiveWorkout = workout;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
