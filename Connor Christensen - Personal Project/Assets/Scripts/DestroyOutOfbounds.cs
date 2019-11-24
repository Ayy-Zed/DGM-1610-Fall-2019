using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfbounds : MonoBehaviour
{
    private float rightBound = 30;
    private float leftBound = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //If objects go too far right they will be destroyed
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        } //If objects go too far left they will be destroyed
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
