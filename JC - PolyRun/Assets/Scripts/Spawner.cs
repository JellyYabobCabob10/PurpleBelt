using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;

    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 1f;

    [Header("Default Spawn Time")]
    public float spawnTime = 2f;

    void Start()
    {
        //start the function after
        //spawnDelay (1) and Repeat the function
        //InstantiateObject every spawnTime (2)
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    void Update()
    {

    }

    void InstantiateObjects()
    {
    Instantiate(challengeObject, transform.position, transform.rotation);
    }
}
