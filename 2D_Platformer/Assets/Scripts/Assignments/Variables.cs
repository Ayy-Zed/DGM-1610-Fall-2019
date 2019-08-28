using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string name = "Connor";
    int age = 20;
    float height = 6.1f;
    bool married = false;
    



    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("First Name: " + name);
        Debug.Log("The Age of the Noble warrior: " + age);
        Debug.Log("Not a short lad, he had a height of: " + height);
        Debug.Log("Though a strapping young man, was he married?: " + married);
    }

   
}
