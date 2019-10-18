using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicsTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameObject> relicsList;
#pragma warning restore 0649
    public List<GameObject> tempRelicsList = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetRandomRelic(GameManager.RelicType.ship);
        }
    }

    public GameObject GetRandomRelic(GameManager.RelicType type)
    {
        tempRelicsList.Clear();
        foreach (GameObject item in relicsList)
        {
            if (item.GetComponent<Relic>().type1 == GameManager.RelicType.all)
                tempRelicsList.Add(item);
            else
            {
                if (item.GetComponent<Relic>().type1 == GameManager.RelicType.none)
                {
                    Debug.LogError("Please configure atleast one relic type for this relic " + item);
                    continue;
                }
                if (item.GetComponent<Relic>().type1 == type)
                {
                    tempRelicsList.Add(item);
                    continue;
                }
                if (item.GetComponent<Relic>().type2 == type)
                {
                    tempRelicsList.Add(item);
                    continue;
                }
                if (item.GetComponent<Relic>().type3 == type)
                {
                    tempRelicsList.Add(item);
                    continue;
                }

            }
        }
        return tempRelicsList[Random.Range(0, tempRelicsList.Count)];
    }
}
