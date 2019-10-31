using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckyClover : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int luckyCloverSailorsReward;
    [SerializeField] int luckyCloverFoodReward;
    [SerializeField] int luckyCloverWoodReward;
    [SerializeField] int luckyCloverGoldReward;
    [SerializeField] RelicData[] data = new RelicData[4];
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.luckyClover = true;
        GameManager.instance.luckyCloverSailor += luckyCloverSailorsReward;
        GameManager.instance.luckyCloverFood += luckyCloverFoodReward;
        GameManager.instance.luckyCloverWood += luckyCloverWoodReward;
        GameManager.instance.luckyCloverGold += luckyCloverGoldReward;
    }

    public override void Unequip()
    {
        GameManager.instance.luckyClover = false;
        GameManager.instance.luckyCloverSailor -= luckyCloverSailorsReward;
        GameManager.instance.luckyCloverFood -= luckyCloverFoodReward;
        GameManager.instance.luckyCloverWood -= luckyCloverWoodReward;
        GameManager.instance.luckyCloverGold -= luckyCloverGoldReward;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
    public override RelicData[] GetData()
    {
        return data;
    }
}
