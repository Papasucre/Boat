using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outlaw : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int extraSailorReward;
    [SerializeField] int extraFoodReward;
    [SerializeField] int extraWoodReward;
    [SerializeField] int extraGoldReward;
    [SerializeField] RelicData[] relicData = new RelicData[4];
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.Outlaw(true);
        GameManager.instance.relicSailorReward += extraSailorReward;
        GameManager.instance.relicFoodReward += extraFoodReward;
        GameManager.instance.relicWoodReward += extraWoodReward;
        GameManager.instance.relicGoldReward += extraGoldReward;
    }

    public override void Unequip()
    {
        GameManager.instance.Outlaw(false);
        GameManager.instance.relicSailorReward -= extraSailorReward;
        GameManager.instance.relicFoodReward -= extraFoodReward;
        GameManager.instance.relicWoodReward -= extraWoodReward;
        GameManager.instance.relicGoldReward -= extraGoldReward;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
    public override RelicData[] GetData()
    {
        return relicData;
    }
}
