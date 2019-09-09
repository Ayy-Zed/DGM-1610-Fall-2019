using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superhero : MonoBehaviour
{
    string superHeroName = "Captain Oakely";
    string superPower = "Turns into an Oak Tree on Command";
    int age = 37;
    float height = 5.8f;
    bool married = false;
    



    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Look in the sky! It's " + superHeroName);
        Debug.Log("He will save us with his power! He " + superPower);
        Debug.Log("I can't believe he is only " + age + "!");
        Debug.Log("Too bad he is pretty short, only " + height);
        Debug.Log("True or false, Captain Oakley is married: " + married);
    }

   
}