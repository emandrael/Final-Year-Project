using Scriptable_Object_Scripts;
using UnityEngine;

namespace Workout_Database_Scripts
{
    public class WorkoutDatabase : MonoBehaviour
    {
        [SerializeField] private WorkoutSO[] _AllWorkouts;

        [SerializeField] private GameObject _WorkoutButton;
        [SerializeField] private Transform _ButtonsParent;

        // Start is called before the first frame update
        void Start()
        {
            foreach (var workout in _AllWorkouts)
            {
                GameObject newButton = Instantiate(_WorkoutButton,_ButtonsParent);
                WorkoutDatabaseButton button = newButton.GetComponent<WorkoutDatabaseButton>();
                button._Workout = workout;
                button.AssignWorkout(workout);
            }
        }

        public void ValueChange(Vector2 vector2)
        {
            Debug.Log(vector2);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
