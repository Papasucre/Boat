﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishnet : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int harvestFoodExtra;
    [SerializeField] RelicData[] relicData = new RelicData[1];
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.harvestFoodReward += harvestFoodExtra;
    }

    public override void Unequip()
    {
        GameManager.instance.harvestFoodReward -= harvestFoodExtra;
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
