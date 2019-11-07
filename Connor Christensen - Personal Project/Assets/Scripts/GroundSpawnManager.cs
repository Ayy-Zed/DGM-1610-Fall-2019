using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnManager : MonoBehaviour
{
    public GameObject[] groundPrefabs;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomGround", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomGround()
    {
        int groundIndex = Random.Range(0, groundPrefabs.Length);
        Instantiate(groundPrefabs[groundIndex], new Vector3(15, 4, -10 ),groundPrefabs[groundIndex].transform.rotation);
    }
}
