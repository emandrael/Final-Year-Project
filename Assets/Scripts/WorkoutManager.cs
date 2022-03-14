using System.Collections;
using System.Collections.Generic;
using TigerForge;
using UnityEngine;

public class WorkoutManager : MonoBehaviour
{
    [SerializeReference] private WorkoutObject currentWorkout;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening("SELECT_WORKOUT",SelectWorkout);
    }

    private void SelectWorkout()
    {
        currentWorkout = (WorkoutObject) EventManager.GetData("SELECT_WORKOUT");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Why Hello There");
    }
}
