﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dog"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("RoadBlock"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }
}
