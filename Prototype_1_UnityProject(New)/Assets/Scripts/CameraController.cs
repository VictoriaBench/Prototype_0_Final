﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float rotateSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SimpleRotate();
    }

    void SimpleRotate()
    {
        this.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime); //spins me right round baby right round
    }

}
