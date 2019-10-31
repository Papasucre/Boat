﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wreck : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649

    void Start()
    {
        GameManager.instance.CleanChoicesArray();
        GameManager.instance.FoodConsumption();
        print("START WRECK");
        for (int i = 0; i < 3; i++)
        {
            GameManager.instance.choicesArray[i] = actionsList[i];
            GameManager.instance.UIChoices[i].Display(actionsList[i]);
        }
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.ShowRessources();
    }
}
