using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpawnManager : MonoBehaviour
{
    public GameObject[] airPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int airIndex = Random.Range(0, airPrefabs.Length);
            Instantiate(airPrefabs[airIndex], new Vector3(15, 10, -10 ),airPrefabs[airIndex].transform.rotation);
        }
    }
}
