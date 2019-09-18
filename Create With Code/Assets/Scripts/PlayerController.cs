using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Game private variables
    private float speed = 20;
    private float turnSpeed = 75;
    private float horizontalInput;
    private float forwardInput;
    
    // Update is called once per frame
    void Update()
    {
        // This code gives the player control

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // This code will make the vehicle move

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  
    }
}
