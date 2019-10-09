using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogspawnRate = 0.3f;
    private float nextDog = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog)
        {
            nextDog = Time.time + dogspawnRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
