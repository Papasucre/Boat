﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camra_Rotator : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
