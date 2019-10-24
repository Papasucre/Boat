using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondPickaxe : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int harvestGoldExtra;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.harvestGoldReward += harvestGoldExtra;
    }

    public override void Unequip()
    {
        GameManager.instance.harvestGoldReward -= harvestGoldExtra;
    }

    public override void Use()
    {
    }
}
