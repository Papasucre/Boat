using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoneTraveler : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int extraSailorReward;
    [SerializeField] int extraFoodReward;
    [SerializeField] int extraWoodReward;
    [SerializeField] int extraGoldReward;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.LoneTraveler(true);
        GameManager.instance.relicSailorReward += extraSailorReward;
        GameManager.instance.relicFoodReward += extraFoodReward;
        GameManager.instance.relicWoodReward += extraWoodReward;
        GameManager.instance.relicGoldReward += extraGoldReward;
    }

    public override void Unequip()
    {
        GameManager.instance.LoneTraveler(false);
        GameManager.instance.relicSailorReward -= extraSailorReward;
        GameManager.instance.relicFoodReward -= extraFoodReward;
        GameManager.instance.relicWoodReward -= extraWoodReward;
        GameManager.instance.relicGoldReward -= extraGoldReward;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
