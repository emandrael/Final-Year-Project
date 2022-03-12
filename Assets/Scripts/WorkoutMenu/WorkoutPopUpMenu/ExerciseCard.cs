using System;
using Scriptable_Object_Scripts;
using TMPro;
using UnityEngine;

public class ExerciseCard : MonoBehaviour
{
    [SerializeField] private TMP_Text exerciseNameAndSetsCountLabel, exerciseBodyPartLabel;

    //private Image _exerciseImage;
    public void SetCard(ExerciseObject exerciseObject)
    {
        exerciseNameAndSetsCountLabel.text = exerciseObject._Sets.Count + " x " + exerciseObject._ExerciseName;
        exerciseBodyPartLabel.text = Enum.GetName(typeof(BodyPart),exerciseObject._BodyPart);
    }
    
}
