using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipsTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Prob> probList;
#pragma warning restore 0649
    List<string> shipList = new List<string>();
    List<string> copyShipList = new List<string>();

    int totalProb;

    private void Awake()
    {
        DoList();
    }

    void DoList()
    {
        shipList.Clear();
        copyShipList.Clear();
        totalProb = 0;
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
        RemoveItem("Unknown");
        RemoveItem("Allies");
        RemoveItem("Enemies");
        probList.Add(new GameManager.Prob("Unknown",0));
        probList.Add(new GameManager.Prob("Allies", 12));
        probList.Add(new GameManager.Prob("Enemies", 12));
        DoList();
    }

    void RemoveItem(string ID)
    {
        probList.RemoveAll(i => i.ID == ID);
    }
}
