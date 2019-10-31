using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamousExplorer : Relic
{
    [Header("SPECIFICS PARAMETERS")]
#pragma warning disable 0649
    [SerializeField] int famousExplorerReward;
    [SerializeField] RelicData[] relicData = new RelicData[1];
#pragma warning restore 0649

    public override void Equip()
    {
        GameManager.instance.famousExplorer = true;
        GameManager.instance.famousExplorerReward += famousExplorerReward;
        GameManager.instance.famousExplorerCounter = 0;
    }

    public override void Unequip()
    {
        GameManager.instance.famousExplorer = false;
        GameManager.instance.famousExplorerReward -= famousExplorerReward;
        GameManager.instance.famousExplorerCounter = 0;

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
