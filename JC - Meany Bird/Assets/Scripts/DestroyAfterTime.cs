﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Destruction Time")]
    public float timeToDestruction;
    void Start()
    {
        Invoke("DestroyObject", timeToDestruction);
    }

    void DestroyObject() 
    {
        Destroy(gameObject);
    }
}

