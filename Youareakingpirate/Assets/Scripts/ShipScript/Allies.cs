using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Allies : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649
    List<GameManager.Action> list = new List<GameManager.Action>();

    bool friendsUpgradeGift;
    bool friendsRelicGift;

    void Start()
    {
        GameManager.instance.CleanChoicesArray();
        GameManager.instance.FoodConsumption();
        friendsRelicGift = false;
        friendsUpgradeGift = false;
        GameManager.instance.encounterNameTxt.text = SceneManager.GetActiveScene().name;
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
                    int random = Random.Range(0, 2);
                    switch (random)
                    {
                        case 0:
                            friendsUpgradeGift = true;
                            break;
                        case 1:
                            friendsRelicGift = true;
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
        for (int i = 0; i < 2; i++)
        {
            GameManager.instance.choicesArray[i] = list[i];
            GameManager.instance.UIChoices[i].Display(list[i]);
        }
        if (friendsUpgradeGift)
        {
            GameManager.instance.gameObject.GetComponent<CarpenterDataTable>().GetFriendsRandomUpgrade();
        }else if (friendsRelicGift)
        {
            GameManager.instance.gameObject.GetComponent<RelicsTable>().GetFriendsRandomRelic(GameManager.RelicType.all, false);
        }
            
        friendsUpgradeGift = false;
        friendsRelicGift = false;
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.UpdateRessources();
    }
}
