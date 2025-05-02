using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Default Speed")]
    public float speed = 6;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Add vector3.left (-1,0,0) to our transform, times by speed
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
