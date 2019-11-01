using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkMerchant : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Action> actionsList;
#pragma warning restore 0649
    public List<GameManager.Action> list;

    void Start()
    {
        GameManager.instance.CleanChoicesArray();
        GameManager.instance.FoodConsumption();
        GameManager.instance.encounterNameTxt.text = SceneManager.GetActiveScene().name;
        for (int i = 0; i < actionsList.Count; i++)
        {
            if(i != 2)
            {
                list.Add(actionsList[i]);
            }
            else
            {
                switch (Random.Range(0,4))
                {
                    case 0:
                        list.Add(actionsList[2]);
                        break;
                    case 1:
                        list.Add(actionsList[3]);
                        break;
                    case 2:
                        list.Add(actionsList[4]);
                        break;
                    case 3:
                        list.Add(actionsList[5]);
                        break;
                    default:
                        break;
                }
                break;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            GameManager.instance.choicesArray[i] = list[i];
            GameManager.instance.UIChoices[i].Display(list[i]);
        }
        GameManager.Instance.makeChoice = true;
        GameManager.instance.skipButton.enabled = true;
        GameManager.Instance.UpdateRessources();
    }
}
