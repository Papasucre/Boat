using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IslandEncounterDataTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
    [SerializeField] List<GameManager.Prob> probList;
#pragma warning restore 0649
    HelpVillagersDataTable helpVillagersScript;
    List<string> IDList = new List<string>();
    List<string> copyIDList = new List<string>();

    int totalProb;

    private void Awake()
    {
        foreach (GameManager.Prob item in probList)
        {
            totalProb += item.prob;
        }
        if (totalProb != 100)
            Debug.LogError("Total of probability is not egal to 100. (=" + totalProb + ")");
        foreach (GameManager.Prob item in probList)
        {
            for (int i = 0; i < item.prob; i++)
            {
                IDList.Add(item.ID);
            }
        }
        copyIDList.AddRange(IDList);
    }

    private void Start()
    {
        GameManager.instance.choicesList.Clear();
        GameManager.instance.FoodConsumption();
        helpVillagersScript = GetComponent<HelpVillagersDataTable>();
        print("START ISLAND");
        for (int i = 0; i < 3; i++)
        {
            string ID = GetChoiceID();
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
                        print(item.ID + " =============================== " + item.actionName);
                        print("Cost : " + "SAILOR " + GameManager.instance.GetSailorCost(item.sailorPrice) + " | " + " FOOD " + GameManager.instance.GetFoodCost(item.foodPrice) + " | " +
                            " WOOD " + GameManager.instance.GetWoodCost(item.woodPrice) + " | " + " GOLD " + GameManager.instance.GetGoldCost(item.goldPrice) + " | " + " RELIC " + item.relicPrice);
                        print("Reward : " + "SAILOR " + item.sailorReward + " | " + " FOOD " + item.foodReward + " | " + " WOOD " + item.woodReward + " | " + " GOLD " + item.goldReward + " | " + " RELIC " + item.relicReward);
                        break;
                    }
                }
            }
        }
        GameManager.Instance.makeChoice = true;
        GameManager.instance.canSkip = true;
        GameManager.Instance.ShowRessources();
        print("Choose your action with 1 2 or 3.");
        print("Or you can skip this encounter with 4.");
    }

    string GetChoiceID()
    {
        string ID = GetRandomID();
        RemoveItem(ID);
        return ID;
    }

    void RemoveItem(string ID)
    {
        copyIDList.RemoveAll(i => i == ID);
    }

    string GetRandomID()
    {
        return copyIDList[Random.Range(0, copyIDList.Count)];
    }
}
