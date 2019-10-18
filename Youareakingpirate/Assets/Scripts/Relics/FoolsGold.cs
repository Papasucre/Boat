using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoolsGold : Relic
{
    public int goldCost;

    public override void Equip()
    {
        GameManager.instance.relicGoldCost += goldCost;
    }

    public override void Unequip()
    {
        GameManager.instance.relicGoldCost -= goldCost;
    }

    public override void Use()
    {
    }
}
