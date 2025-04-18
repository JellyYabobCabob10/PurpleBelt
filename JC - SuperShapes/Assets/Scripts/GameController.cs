using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;

    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 2;

    [Header("Default Spawn Time")]
    public float spawnTime = 3;

    [Header("Game Over UI Canvas")]
    public GameObject gameOverCanvas;

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);

        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    public void GameOver()
    {
        CancelInvoke("Spawn");

        gameOverCanvas.SetActive(true);

        Time.timeScale = 0;
    }
}
