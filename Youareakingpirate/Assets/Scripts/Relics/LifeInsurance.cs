using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeInsurance : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int revenueLifeInsurance;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.lifeInsurance = true;
        GameManager.instance.lifeInsuranceRevenue += revenueLifeInsurance;
    }

    public override void Unequip()
    {
        GameManager.instance.lifeInsurance = false;
        GameManager.instance.lifeInsuranceRevenue -= revenueLifeInsurance;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
