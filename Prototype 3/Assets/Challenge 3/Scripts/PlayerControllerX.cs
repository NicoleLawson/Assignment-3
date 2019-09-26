/*
 * Nicole Lawson
 * PlayerControllerX
 * Assignment 5
 * Allows the player to controll the balloon
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;

    private bool isLowEnough;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        playerRb = GetComponent<Rigidbody>();
        
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

        
    }

    // Update is called once per frame
    void Update()
    {
        //If the player is too high then they can't add more upwards force
        if (this.transform.position.y > 17)
        {
            isLowEnough = false;
        }
        else
        {
            isLowEnough = true;

        }
        // While space is pressed and player is low enough, float up
        if(Input.GetKeyDown(KeyCode.Space) && !gameOver && !isLowEnough)
        {
            //playerRb.AddForce(Vector3.up * 0);
        }
        else if (Input.GetKey(KeyCode.Space) && !gameOver && isLowEnough)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }
        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }
        //if the player collides with the ground, bounce up
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("it gets here");
            playerRb.AddForce(Vector3.up * 450f);
            playerAudio.PlayOneShot(bounceSound, 1.0f);
        }

    }

}
