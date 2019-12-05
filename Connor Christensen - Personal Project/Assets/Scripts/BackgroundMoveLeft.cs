using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveLeft : MonoBehaviour
{
    public float speed;

    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {//Gets the Player Controller script to detect when game is over
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {   //As long as the game is not over the background will move
        Invoke("BackgroundMove", 1.45f);
    }

    void BackgroundMove()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
