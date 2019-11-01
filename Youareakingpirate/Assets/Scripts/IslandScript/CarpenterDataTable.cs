using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpenterDataTable : MonoBehaviour
{
#pragma warning disable 0649
    public List<Upgrade> upgradesList;
    [SerializeField] List<GameManager.ProbUpgrade> probList;
#pragma warning restore 0649
    List<string> IDList = new List<string>();

    RelicsTable relicsScript;

    int totalProb;
    int upgradeBought = 0;

    private void Start()
    {
        relicsScript = GetComponent<RelicsTable>();
        for (int i = 0; i < GetComponents<Upgrade>().Length; i++)
        {
            upgradesList.Add(GetComponents<Upgrade>()[i]);
        }
    }

    void FullProbList()
    {
        IDList.Clear();
        totalProb = 0;
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
                        if(GameManager.instance.currentBoat != GameManager.BoatLevel.little)
                        {
                            for (int i = 0; i < item.prob; i++)
                            {
                                IDList.Add(item.ID);
                            }
                        }
                        break;
                    case GameManager.GameLevel.lvl3:
                        if(GameManager.instance.currentBoat == GameManager.BoatLevel.big)
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
        foreach (DisplayChoice item in GameManager.instance.UIChoices)
        {
            item.Undisplay();
        }
        FullProbList();
        GameManager.instance.CleanUpgradeArray();
        GameManager.instance.CleanCarpenterRelics();
        print("CARPENTER WORKSHOP");
        for (int i = 0; i < 3; i++)
        {
            if (IDList.Count == 0)
                break;
            string ID = GetChoiceID();
            if (ID == "Relic")
            {
                GameObject relic = relicsScript.GetRandomRelic(GameManager.RelicType.carpenter, false);
                if(relic == null)
                {
                    i--;
                    continue;
                }
                GameManager.instance.carpenterRelics[i] = relic;
                Relic relicScript = relic.GetComponent<Relic>();
                GameManager.instance.UIChoices[i].Display(relic);
                if (relicScript.goldPrice == 0)
                    Debug.LogError("ERROR NO FREE RELIC AT CARPENTER WORKSHOP " + relicScript.name);
                print(relicScript.description);
                continue;                
            }
            foreach (Upgrade item in upgradesList)
            {
                if (item.ID == ID)
                {
                    GameManager.instance.choicesUpgradeArray[i] = item;
                    GameManager.instance.UIChoices[i].Display(item);
                    break;
                }
            }
        }
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.atCarpenterWorkshop = true;
        GameManager.Instance.skipButton.enabled = true;
        GameManager.Instance.UpdateRessources();
    }

    public void GetFriendsRandomUpgrade()
    {
        FullProbList();
        RemoveItem("Relic");
        GameManager.instance.CleanUpgradeArray();
        if (IDList.Count == 0)
            return;
        string ID = GetChoiceID();
        foreach (Upgrade item in upgradesList)
        {
            if (item.ID == ID)
            {
                GameManager.instance.choicesUpgradeArray[2] = item;
                GameManager.instance.UIChoices[2].Display(item);
                break;
            }
        }
        GameManager.instance.alliesGift = true;
    }

    public void UpgradePurchase()
    {
        upgradeBought++;
        switch (GameManager.instance.currentBoat)
        {
            case GameManager.BoatLevel.little:
                if (upgradeBought == 2)
                {
                    GameManager.instance.currentBoat = GameManager.BoatLevel.normal;
                    print("Nique sa mere la sloop, on change de bateau.");
                }
                break;
            case GameManager.BoatLevel.normal:
                if (upgradeBought == 4)
                {
                    GameManager.instance.currentBoat = GameManager.BoatLevel.big;
                    print("A toi le galion petite salope !");
                }
                break;
            case GameManager.BoatLevel.big:
                break;
            default:
                print("You can't be there.");
                break;
        }
    }

    bool GetBoolState(string ID)
    {
        foreach (Upgrade item in upgradesList)
        {
            if (ID == item.ID)
            {
                return item.bought;
            }
        }
        if(ID == "Relic")
        {
            return false;
        }
        Debug.LogError("You shoudln't be there. " + ID);
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

    public void SetBoolState(string ID, bool state)
    {
        for (int i = 0; i < upgradesList.Count; i++)
        {
            if(ID == upgradesList[i].ID)
            {
                upgradesList[i].bought = state;
                break;
            }
        }
    }
}
