using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friends : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649
    List<GameManager.Action> list = new List<GameManager.Action>();

    void Start()
    {
        GameManager.instance.choicesList.Clear();
        GameManager.instance.FoodConsumption();
        print("START ALLIES");
        for (int i = 0; i < actionsList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    list.Add(actionsList[i]);
                    break;
                case 1:
                    list.Add(actionsList[Random.Range(1, 5)]);
                    i = 4;
                    break;
                case 5:
                    int random = Random.Range(0, 1);//Replace by 0,2 when relics add
                    switch (random)
                    {
                        case 0:
                            GameManager.instance.gameObject.GetComponent<CarpenterDataTable>().GetRandomUpgrade();
                            break;
                        case 1:
                            //relics
                            break;
                        default:
                            print("You shouldn't be there.");
                            break;
                    }
                    break;
                default:
                    print("You shouldn't be there.");
                    break;
            }            
        }
        foreach (GameManager.Action item in list)
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
