using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    // Start is called before the first frame update
    void Start()
    {//Finds gameManager object to assign points to prefabs
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {//Assigns points to dogs and food on collision
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
        }

    }
}
