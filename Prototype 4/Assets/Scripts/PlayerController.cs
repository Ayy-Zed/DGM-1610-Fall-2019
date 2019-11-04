using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public GameObject powerUpIndicator;

    public float speed;
    private float powerUpStrength = 15;

    public bool hasPowerup;

    // Start is called before the first frame update
    void Start()
    {   
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        //Moves Indicator onto player
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {   //Checks if we have a powerup, sets to true, destroys powerup, and starts timer
        if(other.CompareTag("PowerUp"))
        {
            hasPowerup = true;
            powerUpIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {   //Gives powerup a timer
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {   //Gives player strength when powerup is picked up
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
            Debug.Log("Collided with" + collision.gameObject.name + "with powerup set to " + hasPowerup);
        }
    }
}
