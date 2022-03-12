using System;
using TigerForge;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ScrollRectStart : MonoBehaviour
    {
        private ScrollRect _scrollRect;
        // Start Function for the Scroll Rect, Set's the position of the scroll view to the top of the list.
        private void Start()
        {
            _scrollRect = GetComponent<ScrollRect>();
            EventManager.StartListening("SCROLL_VIEW_RESET",SetScrollViewToTop);
        }

        private void OnDisable()
        {
            EventManager.StopListening("SCROLL_VIEW_RESET",SetScrollViewToTop);
        }
        

        public void SetScrollViewToTop() 
        {
            Canvas.ForceUpdateCanvases();
            _scrollRect.normalizedPosition = Vector2.up;
        }
    }
} 
