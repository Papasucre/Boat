using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicsTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameObject> relicsList;
    [Header("PROB REWARD %")]
    [SerializeField] int low;
    [SerializeField] int medium;
    [SerializeField] int high;
#pragma warning restore 0649
    List<GameObject> tempRelicsList = new List<GameObject>();
    List<GameObject> foreachList = new List<GameObject>();

    public GameObject GetRandomRelic(GameManager.RelicType type, bool includeCurse)
    {
        tempRelicsList.Clear();
        foreach (GameObject item in relicsList)
        {
            if (type == GameManager.RelicType.all)
                tempRelicsList.Add(item);
            else
            {
                Relic tempScript = item.GetComponent<Relic>();
                if (tempScript.type1 == GameManager.RelicType.none)
                {
                    Debug.LogError("Please configure atleast one relic type for this relic " + item);
                    continue;
                }
                if(tempScript.type1 == GameManager.RelicType.all && type != GameManager.RelicType.carpenter)
                {
                    tempRelicsList.Add(item);
                    continue;
                }
                if ((tempScript.type1 == type) || (tempScript.type2 == type) || (tempScript.type3 == type))
                {
                    tempRelicsList.Add(item);
                    continue;
                }
            }
        }
        if (!includeCurse)
        {
            foreachList.Clear();
            foreachList.AddRange(tempRelicsList);
            foreach (GameObject item in foreachList)
            {
                if (item.GetComponent<Relic>().curse)
                    tempRelicsList.Remove(item);
            }
        }
        if (tempRelicsList.Count == 0)
            return null;
        else
            return tempRelicsList[Random.Range(0, tempRelicsList.Count)];
    }

    public void GetFriendsRandomRelic(GameManager.RelicType type, bool includeCurse)
    {
        GameManager.instance.CleanCarpenterRelics();
        GameObject relic = GetRandomRelic(type, includeCurse);
        if (relic == null)
            return;
        GameManager.instance.carpenterRelics[2] = relic;
        Relic relicScript = relic.GetComponent<Relic>();
        print("++++++++++++++++++++++++++++++++++++++++++++++++");
        print("Relic =============================== " + relicScript.name);
        print(relicScript.description);
        GameManager.instance.alliesGift = true;
    }

    public void RemoveGainedRelic(GameObject relic)
    {
        relicsList.Remove(relic);
    }

    public void AddLostRelic(GameObject relic)
    {
        relicsList.Add(relic);
    }

    public bool ProbGetRelic(GameManager.Cost chance)
    {
        switch (chance)
        {
            case GameManager.Cost.none:
                break;
            case GameManager.Cost.low:
                if (Random.Range(0, 100) < low)
                    return true;
                break;
            case GameManager.Cost.medium:
                if (Random.Range(0, 100) < medium)
                    return true;
                break;
            case GameManager.Cost.high:
                if (Random.Range(0, 100) < high)
                    return true;
                break;
            default:
                break;
        }
        return false;
    }
}
