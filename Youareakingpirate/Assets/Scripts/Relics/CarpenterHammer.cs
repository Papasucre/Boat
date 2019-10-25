using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpenterHammer : Relic
{
    public override void Equip()
    {
        GameManager.instance.carpenterHammer = true;
    }

    public override void Unequip()
    {
        GameManager.instance.carpenterHammer = false;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
