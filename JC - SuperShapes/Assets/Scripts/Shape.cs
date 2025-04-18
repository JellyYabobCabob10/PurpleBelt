using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 3;

    void Start()
    {
        rb.rotation = Random.Range(0, 360);

        transform.localScale = Vector3.one * 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x < 0.05f) 
        {
            Destroy(gameObject);
            Score.score++;
        }
    }
}
