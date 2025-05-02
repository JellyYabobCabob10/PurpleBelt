using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Destruction Time")]
    public float timeToDestruction = 6;

    void Start()
    {
        Invoke("DestroyObject", timeToDestruction);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
    void Update()
    {

    }
}

