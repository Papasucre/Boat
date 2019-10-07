using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Encounter : MonoBehaviour
{
    public EncounterType encounterType;

    public enum EncounterType
    {
        none, heading, islandLoad, island, merchant, wreck, pirates
    }

    private void Start()
    {
        
    }

    public abstract void LoadUI();
    public abstract void UnloadUI();
}
