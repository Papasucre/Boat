using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpenterHammer : Relic
{
    RelicData[] relicData = new RelicData[1];

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
    public override RelicData[] GetData()
    {
        return relicData;
    }
}
