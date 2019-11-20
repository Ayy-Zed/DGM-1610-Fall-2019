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
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomGround", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomGround()
    {
        if (playerControllerScript.gameOver == false)
        {
            int groundIndex = Random.Range(0, groundPrefabs.Length);
            Instantiate(groundPrefabs[groundIndex], new Vector3(25, 2.5f, -10 ),groundPrefabs[groundIndex].transform.rotation);
        }
    }
}
