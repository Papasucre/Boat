using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipsTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Prob> probList;
    [SerializeField] int alliesProb = 12;
    [SerializeField] int enemiesProb = 12;
#pragma warning restore 0649
    List<string> shipList = new List<string>();
    List<string> copyShipList = new List<string>();

    bool unknownDiscover;

    int merchantProb;
    int darkMerchantProb;

    private void Awake()
    {
        DoList();
    }

    void DoList()
    {
        shipList.Clear();
        copyShipList.Clear();
        foreach (GameManager.Prob item in probList)
        {
            for (int i = 0; i < item.prob; i++)
            {
                shipList.Add(item.ID);
            }
        }
        copyShipList.AddRange(shipList);
    }

    public void LoadRandomShip()
    {
        SceneManager.LoadScene(copyShipList[Random.Range(0, copyShipList.Count)]);
    }

    public void UnknownDiscover()
    {
        unknownDiscover = true;
        RemoveItem("Unknown");
        RemoveItem("Allies");
        RemoveItem("Enemies");
        probList.Add(new GameManager.Prob("Unknown",0));
        probList.Add(new GameManager.Prob("Allies", alliesProb));
        probList.Add(new GameManager.Prob("Enemies", enemiesProb));
        DoList();
    }

    public void Spyglass(int probValue)
    {
        if (unknownDiscover)
        {
            int probEnemies = 0;
            int probPirates = 0;
            foreach (GameManager.Prob item in probList)
            {
                switch (item.ID)
                {
                    case "Enemies":
                        probEnemies = item.prob;
                        break;
                    case "Pirates":
                        probPirates = item.prob;
                        break;
                    default:
                        break;
                }
            }
            RemoveItem("Enemies");
            RemoveItem("Pirates");
            probList.Add(new GameManager.Prob("Enemies", probEnemies + probValue));
            probList.Add(new GameManager.Prob("Pirates", probPirates + probValue));
            DoList();
        }
        else
        {
            int probPirates = 0;
            foreach (GameManager.Prob item in probList)
            {
                switch (item.ID)
                {
                    case "Pirates":
                        probPirates = item.prob;
                        break;
                    default:
                        break;
                }
            }
            RemoveItem("Pirates");
            probList.Add(new GameManager.Prob("Pirates", probPirates + probValue));
            enemiesProb += probValue;
            DoList();
        }
    }

    public void Outlaw(bool value)
    {
        if (value)
        {
            foreach (GameManager.Prob item in probList)
            {
                switch (item.ID)
                {
                    case "Merchant":
                        merchantProb = item.prob;
                        break;
                    case "DarkMerchant":
                        darkMerchantProb = item.prob;
                        break;
                    default:
                        break;
                }
            }
            RemoveItem("Merchant");
            RemoveItem("DarkMerchant");
            probList.Add(new GameManager.Prob("Merchant", 0));
            probList.Add(new GameManager.Prob("DarkMerchant", 0));
            DoList();
        }
        else
        {
            RemoveItem("Merchant");
            RemoveItem("DarkMerchant");
            probList.Add(new GameManager.Prob("Merchant", merchantProb));
            probList.Add(new GameManager.Prob("DarkMerchant", darkMerchantProb));
            DoList();
        }
    }

    void RemoveItem(string ID)
    {
        probList.RemoveAll(i => i.ID == ID);
    }
}
