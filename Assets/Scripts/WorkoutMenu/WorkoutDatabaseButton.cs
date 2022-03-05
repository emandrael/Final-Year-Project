using System;
using System.Collections;
using System.Collections.Generic;
using Doozy.Runtime.UIManager.Components;
using TMPro;
using UnityEngine;

public class WorkoutDatabaseButton : MonoBehaviour
{
    private TMP_Text tmpText;
    private UIButton uiButton;
    [SerializeField] private WorkoutObject _ButtonWorkoutObject;

    private void OnEnable()
    {
        tmpText = GetComponentInChildren<TMP_Text>();
    }

    public void SetButton(string buttonText, WorkoutObject workoutObject)
    {
        gameObject.name = buttonText;
        tmpText.text = buttonText;
        _ButtonWorkoutObject = workoutObject;
    }
}
