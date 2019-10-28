using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeysPaw : Relic
{
    public override void Equip()
    {
        GameManager.instance.monkeysPaw = true;
    }

    public override void Unequip()
    {
        GameManager.instance.monkeysPaw = false;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
