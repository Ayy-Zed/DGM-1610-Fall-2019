using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnManager : MonoBehaviour
{
    public GameObject[] groundPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int groundIndex = Random.Range(0, groundPrefabs.Length);
            Instantiate(groundPrefabs[groundIndex], new Vector3(15, 4, -10 ),groundPrefabs[groundIndex].transform.rotation);
        }
    }
}
