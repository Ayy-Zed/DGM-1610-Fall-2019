﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {   //Spawns obstacles and allows us to use the game over from another class
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {   //Stops the obstacles from spawning if game is over
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab,spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
