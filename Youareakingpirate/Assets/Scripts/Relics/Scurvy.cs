using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scurvy : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int foodConsumptionExtra;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.relicFoodConsumption += foodConsumptionExtra;
    }

    public override void Unequip()
    {
        GameManager.instance.relicFoodConsumption -= foodConsumptionExtra;
    }

    public override void Use()
    {
    }
}
