using System.Collections.Generic;
using Scriptable_Object_Scripts;
using TigerForge;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace WorkoutMenu.WorkoutPopUpMenu
{
    public class WorkoutPopUp : MonoBehaviour
    {
        private WorkoutObject _currentlyViewedWorkoutObject;
        [SerializeField] private TMP_Text workoutName;

        [SerializeField] private ExerciseCard exerciseCardPrefab;
        [SerializeField] private Transform parent;

        [SerializeField] private List<ExerciseCard> _exerciseCards;

        // Start is called before the first frame update
        void OnEnable()
        {
            EventManager.StartListening(EventConstants.CHECK_WORKOUT,SetViewedWorkout);
        }

        private void OnDisable()
        {
            EventManager.StopListening(EventConstants.CHECK_WORKOUT,SetViewedWorkout);
        }

        private void SetViewedWorkout()
        {
            _currentlyViewedWorkoutObject =
                (WorkoutObject) EventManager.GetData(EventConstants.CHECK_WORKOUT);
            
            workoutName.text = _currentlyViewedWorkoutObject._WorkoutName;
            
            foreach (var card in _exerciseCards)
            {
                Destroy(card.GameObject());
            }
            _exerciseCards = new List<ExerciseCard>();
            
            foreach (var exercise in _currentlyViewedWorkoutObject._Exercises)
            {
                CreateExerciseCardWith(exercise);
            }
            
        }

        private void CreateExerciseCardWith(ExerciseObject exerciseObject)
        {
            var exerciseCard = Instantiate(exerciseCardPrefab,parent);
            _exerciseCards.Add(exerciseCard);
            exerciseCard.SetCard(exerciseObject);
        }

        public void OnSelectWorkoutPressed()
        {
            EventManager.EmitEventData(EventConstants.WORKOUT_SELECT,_currentlyViewedWorkoutObject);
        }
    }
}
