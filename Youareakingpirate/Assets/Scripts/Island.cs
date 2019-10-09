using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Island : Encounter
{
    [Header("CAMERA TARGET POS/ROT")]
#pragma warning disable 0649
    [SerializeField] public GameObject dockingPos;
    [SerializeField] public GameObject exitDirection;
#pragma warning restore 0649

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            UnloadUI();
        }
    }

    public override void LoadUI()
    {
        GameObject.FindGameObjectWithTag("RessourcesUI").GetComponent<RessourcesUI>().ShowRessources(true);
    }

    public override void UnloadUI()
    {
        GameObject.FindGameObjectWithTag("RessourcesUI").GetComponent<RessourcesUI>().ShowRessources(false);
    }
}
