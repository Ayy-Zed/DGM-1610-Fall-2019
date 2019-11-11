using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpawnManager : MonoBehaviour
{
    public GameObject[] airPrefabs;

    private float startDelay = 2;
    private float spawnInterval = 2.0f;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
        InvokeRepeating("SpawnRandomAir", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAir()
    {
        if (playerControllerScript.gameOver == false)
        {
            int airIndex = Random.Range(0, airPrefabs.Length);
            Instantiate(airPrefabs[airIndex], new Vector3(15, 10, -10 ),airPrefabs[airIndex].transform.rotation);
        }
    }
}
