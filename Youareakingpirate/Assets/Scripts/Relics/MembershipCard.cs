﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MembershipCard : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int merchantGoldCost;
    [SerializeField] RelicData[] relicData = new RelicData[1];
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.merchantGoldCost += merchantGoldCost;
    }

    public override void Unequip()
    {
        GameManager.instance.merchantGoldCost -= merchantGoldCost;
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
