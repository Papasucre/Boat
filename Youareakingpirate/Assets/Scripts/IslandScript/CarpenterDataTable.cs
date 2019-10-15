using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpenterDataTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Upgrade> upgradesList;
    [SerializeField] List<GameManager.ProbUpgrade> probList;
#pragma warning restore 0649
    List<string> IDList = new List<string>();

    int totalProb;

    void FullProbList()
    {
        IDList.Clear();
        foreach (GameManager.ProbUpgrade item in probList)
        {
            totalProb += item.prob;
        }
        if (totalProb != 100)
            Debug.LogError("Total of probability is not egal to 100. (=" + totalProb + ")");
        foreach (GameManager.ProbUpgrade item in probList)
        {
            if (!GetBoolState(item.ID))
            {
                switch (item.levelUpgrade)
                {
                    case GameManager.GameLevel.lvl1:
                        for (int i = 0; i < item.prob; i++)
                        {
                            IDList.Add(item.ID);
                        }
                        break;
                    case GameManager.GameLevel.lvl2:
                        if(GameManager.instance.currentLevel != GameManager.GameLevel.lvl1)
                        {
                            for (int i = 0; i < item.prob; i++)
                            {
                                IDList.Add(item.ID);
                            }
                        }
                        break;
                    case GameManager.GameLevel.lvl3:
                        if(GameManager.instance.currentLevel == GameManager.GameLevel.lvl3)
                        {
                            for (int i = 0; i < item.prob; i++)
                            {
                                IDList.Add(item.ID);
                            }
                        }
                        break;
                    default:
                        Debug.LogError("You shoudln't be there.");
                        break;
                }
            }
        }
    }

    public void AtCarpenter()
    {
        FullProbList();
        GameManager.instance.choicesUpgradeList.Clear();
        print("CARPENTER WORKSHOP");
        for (int i = 0; i < 3; i++)
        {
            string ID = GetChoiceID();
            foreach (GameManager.Upgrade item in upgradesList)
            {
                if (item.ID == ID)
                {
                    GameManager.instance.choicesUpgradeList.Add(item);
                    print(item.ID + " =============================== " + item.actionName);
                    print("Cost : " + " GOLD " +GameManager.instance.GetGoldCostCarpenter(item.goldPrice));
                    print("New capacity : " +item.newCapacity);
                    break;
                }
            }
        }
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.atCarpenterWorkshop = true;
        GameManager.Instance.ShowRessources();
        print("Choose your action with 1 2 or 3.");
    }

    bool GetBoolState(string ID)
    {
        foreach (GameManager.Upgrade item in upgradesList)
        {
            if (ID == item.ID)
            {
                return item.bought;
            }
        }
        Debug.LogError("You shoudln't be there.");
        return true;
    }

    string GetChoiceID()
    {
        string ID = GetRandomID();
        RemoveItem(ID);
        return ID;
    }

    void RemoveItem(string ID)
    {
        IDList.RemoveAll(i => i == ID);
    }

    string GetRandomID()
    {
        return IDList[Random.Range(0, IDList.Count)];
    }
}
