﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RelicIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Relic relicScript;
    public GameObject popUp;
    RelicPopUp popUpScript;
    Canvas popUpCanvas;

    private void Start()
    {
        popUpScript = popUp.GetComponent<RelicPopUp>();
        popUpCanvas = popUp.GetComponent<Canvas>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(relicScript && GetComponent<Image>().sprite.name != "Empty")
        {
            popUpCanvas.enabled = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (relicScript)
        {
            popUpCanvas.enabled = false;
        }
    }

    public void SetRelic(Relic relic)
    {
        relicScript = relic;
        popUpScript.SetData(relic);
    }
}
