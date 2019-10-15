using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpVillagersDataTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649
    HelpVillagersProb probScript;

    public GameManager.Action RandomHelpVillagers()
    {
        probScript = GetComponent<HelpVillagersProb>();
        string ID = probScript.GetEncounterID();
        foreach (GameManager.Action item in actionsList)
        {
            if (item.ID == ID)
            {
                print(item.ID + " " + item.actionName + " ===============================");
                print("Cost : " + "SAILOR " + item.sailorPrice + " FOOD " + item.foodPrice + " WOOD " + item.woodPrice + " GOLD " + item.goldPrice + " RELIC " + item.relicPrice);
                print("Reward : " + "SAILOR " + item.sailorReward + " FOOD " + item.foodReward + " WOOD " + item.woodReward + " GOLD " + item.goldReward + " RELIC " + item.relicReward);
                return item;
            }
        }
        Debug.LogError("You shoudln't be there.");
        return new GameManager.Action();
    }
}
