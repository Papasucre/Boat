using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirates : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649

    void Start()
    {
        GameManager.instance.choicesList.Clear();
        GameManager.instance.FoodConsumption();
        print("START PIRATES");
        foreach (GameManager.Action item in actionsList)
        {
            GameManager.instance.choicesList.Add(item);
            print(item.ID + " =============================== " + item.actionName);
            print("Cost : " + "SAILOR " + GameManager.instance.GetSailorCost(item.sailorPrice) + " | " + " FOOD " + GameManager.instance.GetFoodCost(item.foodPrice) + " | " +
                " WOOD " + GameManager.instance.GetWoodCost(item.woodPrice) + " | " + " GOLD " + GameManager.instance.GetGoldCost(item.goldPrice) + " | " + " RELIC " + item.relicPrice);
            print("Reward : " + "SAILOR " + item.sailorReward + " | " + " FOOD " + item.foodReward + " | " + " WOOD " + item.woodReward + " | " + " GOLD " + item.goldReward + " | " + " RELIC " + item.relicReward);
        }
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.ShowRessources();
        print("Choose your action with 1 2 or 3.");
    }
}
