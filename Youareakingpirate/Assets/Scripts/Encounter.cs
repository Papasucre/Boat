using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter : MonoBehaviour
{
#pragma warning disable 0649
    [Header("BOAT ANIMATION")]
    public GameObject dockingPos;
    public GameObject exitDirection;

    [Header("ENCOUNTER CONFIGURATION")]
    public string encounterName;
    [Header("Choice 1")]
    public string choiceName_1;
    public RessourcesType ressource1_1;
    public string ressource1Value_1;
    public RessourcesType ressource2_1;
    public string ressource2Value_1;
    public RessourcesType ressource3_1;
    public string ressource3Value_1;
    public RessourcesType ressource4_1;
    public string ressource4Value_1;
    [Header("Choice 2")]
    public string choiceName_2;
    public RessourcesType ressource1_2;
    public string ressource1Value_2;
    public RessourcesType ressource2_2;
    public string ressource2Value_2;
    public RessourcesType ressource3_2;
    public string ressource3Value_2;
    public RessourcesType ressource4_2;
    public string ressource4Value_2;
    [Header("Choice 3")]
    public string choiceName_3;
    public RessourcesType ressource1_3;
    public string ressource1Value_3;
    public RessourcesType ressource2_3;
    public string ressource2Value_3;
    public RessourcesType ressource3_3;
    public string ressource3Value_3;
    public RessourcesType ressource4_3;
    public string ressource4Value_3;
#pragma warning restore 0649

    public enum RessourcesType
    {
        none, food, wood, gold, sailor
    }
}
