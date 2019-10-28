using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spyglass : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int enemiesAndPiratesProbChange;
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.Spyglass(enemiesAndPiratesProbChange);
    }

    public override void Unequip()
    {
        GameManager.instance.Spyglass(-enemiesAndPiratesProbChange);
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
