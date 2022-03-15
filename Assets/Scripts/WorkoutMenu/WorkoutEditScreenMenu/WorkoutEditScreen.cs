using System.Collections.Generic;
using TigerForge;
using TMPro;
using UnityEngine;

public class WorkoutEditScreen : MonoBehaviour
{
    private WorkoutObject _currentlyViewedWorkoutObject;

    [SerializeField] private Transform grid;
    [SerializeField] private TMP_Text workoutName;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(EventConstants.CHECK_WORKOUT,SetViewedWorkout);
    }

    private void SetViewedWorkout()
    {
        _currentlyViewedWorkoutObject = (WorkoutObject) EventManager.GetData(EventConstants.CHECK_WORKOUT);
        workoutName.text = _currentlyViewedWorkoutObject._WorkoutName;
    }
    
    
    
}
