using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    bool canLoad;

    void LoadMenu()
    {
        canLoad = true;
    }
    private void Update()
    {
        if(Input.anyKey && canLoad)
            SceneManager.LoadScene("Menu");
    }
}
