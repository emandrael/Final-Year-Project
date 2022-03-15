using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditMenuSets : MonoBehaviour
{
    [SerializeField] private RectTransform parent;
    [SerializeField] private EditMenuSet set;

    public void OnAddSet()
    {
        var rect = parent.rect;
        parent.sizeDelta = new Vector2(rect.width, rect.height + 100f);
        
        var yes = Instantiate(set, transform);
        yes.GetComponent<RectTransform>().SetSiblingIndex(transform.childCount - 2);
    }
    
}
