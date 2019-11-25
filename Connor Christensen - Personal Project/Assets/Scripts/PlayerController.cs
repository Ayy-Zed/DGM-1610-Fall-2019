using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject projectile;
    public ParticleSystem explosionParticle;
    public ParticleSystem bombParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;
    private Animator playerAnim;
    private Rigidbody playerRb;
    private GameManager gameManager;

    private float gravityModifier = 10;
    private float jumpForce = 2600;

    private bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()

    {   //Sets up player to be able to add jump force
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *=gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    
    {   //If spacebar is pressed and player is on the ground then jump, also plays sounds and particles as well as animations
        if (Input.GetKeyDown(KeyCode.W) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, .50f);
        }//Shoots projectile on D
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }

    private void OnCollisionEnter (Collision collision)
    {//Only lets player jump when they touch the ground
        if (collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        //Plays and stops animations, sounds, particles, and stops game
        if (collision.gameObject.CompareTag("RoadBlock"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            gameManager.GameOver();

        }//Plays and stops animations, sounds, particles, and stops game
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            bombParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            gameManager.GameOver();
        }
    }
}
