/*
 * Adam Field
 * Prototype3
 * controls the player
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public ForceMode jumpForceMode;

    public float jumpForce;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        playerAnimator.SetFloat("Speed_f", 1.0f);

        jumpForceMode = ForceMode.Impulse;
        if(Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;

            playerAnimator.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!!");
            gameOver = true;

            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound);
        }
    }
}
