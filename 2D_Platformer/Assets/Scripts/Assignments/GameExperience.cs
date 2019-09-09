using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExperience : MonoBehaviour
{
    string itemCrafted = "Sword";
    string materialNeeded = "Stone";
    int levelRequired = 7;
    float expereienceRequired = 56.5f;
    bool killsMobs = True;
    



    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Are you ready to craft the " + itemCrafted);
        Debug.Log("To craft this item, you need 15 " + materialNeeded);
        Debug.Log("To craft this item, you must be at least level " + levelRequired);
        Debug.Log("Make sure you have the required amount of expereience: " + expereienceRequired);
        Debug.Log("True or Falso, This sword is capable of killing mobs:  " + killsMobs);
    }

   
}