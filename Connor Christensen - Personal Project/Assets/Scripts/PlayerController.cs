﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public GameObject projectile;

    private float gravityModifier = 10;
    private float jumpForce = 220;

    private bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()

    {   //Sets up player to be able to add jump force
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *=gravityModifier;
    }

    // Update is called once per frame
    void Update()
    
    {   //If spacebar is pressed and player is on the ground then jump
        if (Input.GetKeyDown(KeyCode.W) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter (Collision collision)
    {//Only lets player jump when they touch the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
        //else if(Input.GetKeyDown(KeyCode.S) && !isOnGround)
        {
           // Instantiate(projectile, transform.position, projectile.transform.rotation);
        }

        if (collision.gameObject.CompareTag("RoadBlock"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
        }
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
        }
    }
}