using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeysPaw : Relic
{
    RelicData[] relicData = new RelicData[0];
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
    public override RelicData[] GetData()
    {
        return relicData;
    }
}
