using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IslandsTable : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] List<GameManager.Prob> probList;
#pragma warning restore 0649
    List<string> islandsList = new List<string>();
    List<string> copyIslandsList = new List<string>();

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
                islandsList.Add(item.ID);
            }
        }
        copyIslandsList.AddRange(islandsList);
    }

    public void LoadRandomIsland()
    {
        string nextScene = copyIslandsList[Random.Range(0, copyIslandsList.Count)];
        while(nextScene == GameManager.instance.lastScene)
        {
            nextScene = copyIslandsList[Random.Range(0, copyIslandsList.Count)];
        }
        GameManager.instance.lastScene = nextScene;
        SceneManager.LoadScene(nextScene);
    }
}
