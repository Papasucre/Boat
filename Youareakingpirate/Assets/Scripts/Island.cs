using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Island : Encounter
{
    private void Start()
    {
        ShowUI(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ShowUI(false);
        }
    }

    void ShowUI(bool show)
    {
        GameObject.FindGameObjectWithTag("UI").GetComponent<DisplayUI>().ShowUI("Encounter", show);
    }


}
