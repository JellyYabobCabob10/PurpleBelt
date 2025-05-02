using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    //Jumping power for the player object
    [Header("Default Jumping Power")]
    public float jumpPower = 6f;
    //True or false if is on the ground
    [Header("Boolean isGrounded")]
    public bool isGrounded;
    //position of the object
    float posX = 0.0f;
    //rigibody2D of the object
    Rigidbody2D rb;

    void Start() {
        //Variable rb equals to Rigidbody2D
        //component on the object
        //this script is attached to
        rb = GetComponent<Rigidbody2D>();
        //posX = starting position
        posX = transform.position.x;
        Time.timeScale = 1;

    }
    void GameOver()
    {
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();

    }

    void Update() {
        //Only jump if we press space and if isGrounded is true
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.AddForce(Vector3.up * jumpPower * rb.mass * rb.gravityScale * 20f);
        }
        //If the player position is
        //less than where it started
        if (transform.position.x < posX)
            {
            //Execute Gameover function
            GameOver();
            }


    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //If the object we collide with has the
        //tag Ground
        if (collision.gameObject.tag == "Ground") {
            //isGrounded is set to true
            isGrounded = true;
        }

        if (collision.gameObject.tag == "Enemy")
        {
            GameOver();
        }




    }
    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            //isGrounded is set to true
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            //Find the game controller and add to our score
            GameObject.Find("GameController").GetComponent<GameController>().IncrementScore();

            Destroy(collision.gameObject);
        }
    }

}