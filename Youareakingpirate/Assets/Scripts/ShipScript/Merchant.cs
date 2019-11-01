using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
    [SerializeField] List<GameManager.Prob> probList;
#pragma warning restore 0649
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
        GameManager.instance.CleanChoicesArray();
        GameManager.instance.FoodConsumption();
        print("START MERCHANT");
        for (int i = 0; i < 3; i++)
        {
            string ID = GetChoiceID();
            foreach (GameManager.Action item in actionsList)
            {
                if (item.ID2 == ID)
                {
                    GameManager.instance.choicesArray[i] = item;
                    GameManager.instance.UIChoices[i].Display(item);
                    break;
                }
            }
        }
        GameManager.Instance.makeChoice = true;
        GameManager.Instance.skipButton.enabled = true;
        GameManager.Instance.UpdateRessources();
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
