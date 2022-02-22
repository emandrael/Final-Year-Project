using Doozy.Runtime.UIManager.Components;
using Scriptable_Object_Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using Doozy.Runtime.UIManager;
using Doozy.Runtime.UIManager.Components;
namespace Workout_Database_Scripts
{
    public class WorkoutDatabaseButton : MonoBehaviour
    {

        public UIButton _UIButton;
        public WorkoutSO _Workout;
        public TextMeshProUGUI _Label;

        public WorkoutEvent OnWorkoutSelected;
        // Start is called before the first frame update
        void OnEnable()
        {
            _UIButton = GetComponent<UIButton>();
            _Label = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void SelectWorkout(WorkoutSO workout)
        {
            OnWorkoutSelected.Invoke(_Workout);
        }
        public void AssignWorkout(WorkoutSO workout)
        {
            _Workout = workout;
            gameObject.name = workout._WorkoutName;
            _Label.SetText( workout._WorkoutName);
        }
    }
}
