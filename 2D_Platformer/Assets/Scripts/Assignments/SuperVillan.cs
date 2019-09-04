using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string superVillanName = "Lucifer";
    string evilPower = "Turn into a red hornded beast";
    int age = 43;
    float height = 6.9f;
    bool nice = false;
    



    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Oh no! It's " + superVillanName);
        Debug.Log("Watch out! he is known to  " + evilPower);
        Debug.Log("I heard he's pretty old! He is:  " + age );
        Debug.Log("The man is a giant, he is " + height);
        Debug.Log("True or false, he is nice: " + married);
    }

   
}