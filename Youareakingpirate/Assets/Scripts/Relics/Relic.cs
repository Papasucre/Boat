using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Relic : MonoBehaviour
{
    [Header("GENERICS PARAMETERS")]
    public new string name;
    public string description;
    public GameManager.GameLevel levelRequiered;
    public GameManager.RelicType type1;
    public GameManager.RelicType type2;
    public GameManager.RelicType type3;
    public bool curse;
    public int goldPrice;

    public abstract void Equip();
    public abstract void Unequip();
    public abstract void Use();
    public abstract RelicData[] GetData();

    [System.Serializable]
    public class RelicData
    {
        public GameManager.ResourceType resource;
        public string value;
    }
}
