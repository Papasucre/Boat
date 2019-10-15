using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IslandEncounterDataTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649
    IslandEncounterProb probScript;
    HelpVillagersDataTable helpVillagersScript;

    private void Start()
    {
        GameManager.instance.choicesList.Clear();
        GameManager.instance.FoodConsumption();
        helpVillagersScript = GetComponent<HelpVillagersDataTable>();
        probScript = GetComponent<IslandEncounterProb>();
        print("START ISLAND");
        for (int i = 0; i < 3; i++)
        {
            string ID = probScript.GetEncounterID();
            foreach (GameManager.Action item in actionsList)
            {
                if (item.ID == ID)
                {
                    if(item.ID == "Is_06")
                    {
                        GameManager.instance.choicesList.Add(helpVillagersScript.RandomHelpVillagers());
                    }
                    else
                    {
                        GameManager.instance.choicesList.Add(item);
                        print(item.ID + " " + item.actionName + " ===============================");
                        print("Cost : " + "SAILOR " + GameManager.instance.GetSailorCost(item.sailorPrice) + " FOOD " + GameManager.instance.GetFoodCost(item.foodPrice) + 
                            " WOOD " + GameManager.instance.GetWoodCost(item.woodPrice) + " GOLD " + GameManager.instance.GetGoldCost(item.goldPrice) + " RELIC " + item.relicPrice);
                        print("Reward : " + "SAILOR " + item.sailorReward + " FOOD " + item.foodReward + " WOOD " + item.woodReward + " GOLD " + item.goldReward + " RELIC " + item.relicReward);
                        break;
                    }
                }
            }
        }
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.ShowRessources();
        print("Choose your action with 1 2 or 3.");
    }
}
