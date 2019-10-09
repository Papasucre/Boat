using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int woodStock;
    public int woodMaxStock;
    public int goldStock;
    public int goldMaxStock;
    public int foodStock;
    public int foodMaxStock;
    public int sailorsStock;
    public int sailorsMaxStock;

    public int choiceFoodValue;
    public int choiceWoodValue;
    public int choiceGoldValue;
    public int choiceSailorValue;

    public static GameManager instance;

    public static GameManager Instance {
        get {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        print(Instance);
        if (GameManager.instance != this)
            Destroy(gameObject);
    }

    private void Update()
    {
        print(choiceSailorValue);
    }

    public void UpdateStock()
    {
       /* woodStock += choiceWoodValue;
        foodStock += choiceFoodValue;
        goldStock += choiceGoldValue;
        sailorsStock += choiceSailorValue;*/
    }


}
