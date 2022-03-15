using TigerForge;
using UnityEngine;

public class WorkoutManager : MonoBehaviour
{
    [SerializeReference] private WorkoutObject currentWorkout;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening(EventConstants.WORKOUT_SELECT,SelectWorkout);
    }

    private void SelectWorkout()
    {
        currentWorkout = (WorkoutObject) EventManager.GetData(EventConstants.WORKOUT_SELECT);
    }
}
