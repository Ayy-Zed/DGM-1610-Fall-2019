using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpawnManager : MonoBehaviour
{
    public GameObject[] airPrefabs;

    private float startDelay = 2;
    private float spawnInterval = 3.3f;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {//Gets Player Controller script to detect game over
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //Spawns random air prefab at designated time
        InvokeRepeating("SpawnRandomAir", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void SpawnRandomAir()
    {//If game is not over, picks a random air prefab and spawns at designated spot
        if (playerControllerScript.gameOver == false)
        {
            int airIndex = Random.Range(0, airPrefabs.Length);
            Instantiate(airPrefabs[airIndex], new Vector3(25, 10, -10 ),airPrefabs[airIndex].transform.rotation);
        }
    }
}
