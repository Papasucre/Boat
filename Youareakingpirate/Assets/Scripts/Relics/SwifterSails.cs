using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwifterSails : Relic
{
    public int woodCost;

    public override void Equip()
    {
        GameManager.instance.swifterSailsValue += woodCost;
    }

    public override void Unequip()
    {
        GameManager.instance.swifterSailsValue -= woodCost;
    }

    public override void Use()
    {
    }
}
