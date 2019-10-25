using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforcedHull : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int fightWoodCost;
    [SerializeField] int runAwayWoodCost;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.fightWoodCost += fightWoodCost;
        GameManager.instance.runAwayWoodCost += runAwayWoodCost;
    }

    public override void Unequip()
    {
        GameManager.instance.fightWoodCost -= fightWoodCost;
        GameManager.instance.runAwayWoodCost += runAwayWoodCost;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
