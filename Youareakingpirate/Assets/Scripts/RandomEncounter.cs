using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEncounter : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Prob> probList;
#pragma warning restore 0649
    List<string> list = new List<string>();

    IslandsTable islandsTableScript;
    ShipsTable shipsTableScript;

    int totalProb;

    private void Awake()
    {
        islandsTableScript = GetComponent<IslandsTable>();
        shipsTableScript = GetComponent<ShipsTable>();
        DoList();
    }

    void DoList()
    {
        list.Clear();
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
                list.Add(item.ID);
            }
        }
    }

    public void LoadRandomEncounter()
    {
        switch (list[Random.Range(0,list.Count)])
        {
            case "Island":
                islandsTableScript.LoadRandomIsland();
                break;
            case "Ship":
                shipsTableScript.LoadRandomShip();
                break;
            default:
                break;
        }
    }
}
