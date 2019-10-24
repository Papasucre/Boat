﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwifterSails : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int woodCost;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.runAwayWoodCost += woodCost;
    }

    public override void Unequip()
    {
        GameManager.instance.runAwayWoodCost -= woodCost;
    }

    public override void Use()
    {
    }
}
