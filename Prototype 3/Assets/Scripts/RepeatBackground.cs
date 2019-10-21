using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
        // Find the position of background so we can reset it
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {   //Resets the position of the background to make it look endless
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }   
    }
}
