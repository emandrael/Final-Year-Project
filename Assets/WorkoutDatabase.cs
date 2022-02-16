using System.Collections;
using System.Collections.Generic;
using Doozy.Editor.UIManager.UIMenu;
using Doozy.Runtime.UIManager.Components;
using Scriptable_Object_Scripts;
using UnityEngine;
using UnityEngine.UI;

public class WorkoutDatabase : MonoBehaviour
{
    [SerializeField] private WorkoutSO[] _AllWorkouts;

    [SerializeField] private GameObject _WorkoutButton;
    [SerializeField] private Transform _ButtonsParent;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yes");
        foreach (var workout in _AllWorkouts)
        { 
            WorkoutDatabaseButton button = _WorkoutButton.GetComponent<WorkoutDatabaseButton>();
            button._Workout = workout;
            Instantiate(_WorkoutButton,_ButtonsParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
