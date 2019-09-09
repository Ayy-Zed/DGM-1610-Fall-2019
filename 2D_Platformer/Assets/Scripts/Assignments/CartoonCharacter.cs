using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartoonCharacters : MonoBehaviour
{
    string cartoonName = "Jack Ludacris";
    string showName = "That boy's Ludacris";
    int age = 14;
    float height = 6.1f;
    bool smart = True;
    



    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Meet" + cartoonName);
        Debug.Log("The new star of the hit cartoon show " + showName);
        Debug.Log("It's a show about a boy who is only " + age);
        Debug.Log("As tall as a normal boy " + height);
        Debug.Log("True or Falso, Jack is a smart boy:  " + smart);
    }

   
}