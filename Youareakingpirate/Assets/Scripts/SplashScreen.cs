﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
