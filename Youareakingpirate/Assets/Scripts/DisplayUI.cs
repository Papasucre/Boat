using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUI : MonoBehaviour
{
    
    public void ShowUI(string UIElement, bool show)
    {
        switch (UIElement)
        {
            case "Encounter":
                for (int i = 0; i < transform.GetChild(0).transform.childCount - 1; i++)
                {
                    transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(show);
                }
                break;
            default:
                break;
        }
    }
}
