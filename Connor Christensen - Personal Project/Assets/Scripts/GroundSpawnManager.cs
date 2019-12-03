using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnManager : MonoBehaviour
{
    public GameObject[] groundPrefabs;

    private float startDelay = 2;
    private float spawnInterval = 1.2f;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {//Finds player controller script to detect game over
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRandomGround()
    {//If game is not over, then spawn random ground prefab at designated spot
        if (playerControllerScript.gameOver == false)
        {
            int groundIndex = Random.Range(0, groundPrefabs.Length);
            Instantiate(groundPrefabs[groundIndex], new Vector3(25, 2.5f, -10 ),groundPrefabs[groundIndex].transform.rotation);
        }
    }

    public void SpawnGround()
    {
        InvokeRepeating("SpawnRandomGround", startDelay, spawnInterval);
    }
}
