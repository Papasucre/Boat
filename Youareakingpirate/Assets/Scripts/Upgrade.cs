using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Upgrade : MonoBehaviour
{
    public string actionName;
    public string ID;
    public GameManager.GameLevel goldPrice;
    public int newCapacity;
    public bool bought;
}
