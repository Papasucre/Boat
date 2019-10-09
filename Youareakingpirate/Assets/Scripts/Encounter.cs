using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Encounter : MonoBehaviour
{
    public EncounterType encounterType;

    public enum EncounterType
    {
        none, island, merchant, wreck, pirates
    }

    public abstract void LoadUI();
    public abstract void UnloadUI();
}
