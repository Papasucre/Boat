using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipsTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Prob> probList;
#pragma warning restore 0649
    public List<string> shipList = new List<string>();
    List<string> copyShipList = new List<string>();

    int totalProb;

    private void Awake()
    {
        foreach (GameManager.Prob item in probList)
        {
            totalProb += item.prob;
        }
        if (totalProb != 100)
            Debug.LogError("Total of probability is not egal to 100. (=" + totalProb+")");
        foreach (GameManager.Prob item in probList)
        {
            for (int i = 0; i < item.prob; i++)
            {
                shipList.Add(item.ID);
            }
        }
        copyShipList.AddRange(shipList);
    }

    public void LoadRandomIsland()
    {
        SceneManager.LoadScene(copyShipList[Random.Range(0, copyShipList.Count)]);
    }

    public void UnknownDiscover()
    {
        //probList[3].prob = 0;
    }
}
