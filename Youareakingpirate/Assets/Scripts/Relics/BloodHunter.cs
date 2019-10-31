using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodHunter : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int fightFoodReward;
    [SerializeField] int fightWoodReward;
    [SerializeField] int fightGoldReward;
    [SerializeField] RelicData[] relicData = new RelicData[3];
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.bloodHunter = true;
        GameManager.instance.fightFoodReward += fightFoodReward;
        GameManager.instance.fightWoodReward += fightWoodReward;
        GameManager.instance.fightGoldReward += fightGoldReward;
    }

    public override void Unequip()
    {
        GameManager.instance.bloodHunter = false;
        GameManager.instance.fightFoodReward -= fightFoodReward;
        GameManager.instance.fightWoodReward -= fightWoodReward;
        GameManager.instance.fightGoldReward -= fightGoldReward;
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
