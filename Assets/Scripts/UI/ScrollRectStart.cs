using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ScrollRectStart : MonoBehaviour
    {
        // Start Function for the Scroll Rect, Set's the position of the scroll view to the top of the list.
        private void Start() => GetComponent<ScrollRect>().normalizedPosition = Vector2.up;
    }
} 
