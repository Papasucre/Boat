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
}
