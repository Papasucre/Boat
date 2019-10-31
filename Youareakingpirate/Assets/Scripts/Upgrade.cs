using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Upgrade : MonoBehaviour
{
    public new string name;
    public string ID;
    public GameManager.GameLevel goldPrice;
    public int newCapacity;
    public bool bought;
}
