using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhuunLegacy : Relic
{
    RelicData[] relicData = new RelicData[0];

    public override void Equip()
    {
        GameManager.instance.ghuunLegacy = true;
    }

    public override void Unequip()
    {
        GameManager.instance.ghuunLegacy = false;
    }

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
    public override RelicData[] GetData()
    {
        return relicData;
    }
}
