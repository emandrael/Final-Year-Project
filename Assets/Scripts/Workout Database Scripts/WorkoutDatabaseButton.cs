using Doozy.Runtime.UIManager.Components;
using Scriptable_Object_Scripts;
using TMPro;
using UnityEngine;

namespace Workout_Database_Scripts
{
    public class WorkoutDatabaseButton : MonoBehaviour
    {

        public UIButton _UIButton;
        public WorkoutSO _Workout;
        public TextMeshProUGUI _Label;

        // Start is called before the first frame update
        void OnEnable()
        {
            _UIButton = GetComponent<UIButton>();
            _Label = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void AssignWorkout(WorkoutSO workout)
        {
            _Workout = workout;
            gameObject.name = workout._WorkoutName;
            _Label.text = workout._WorkoutName;

        }
    
    
    
    }
}
