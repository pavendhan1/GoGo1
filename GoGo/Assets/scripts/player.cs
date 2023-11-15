using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAN;
    private AudioSource playerAudio;
    public ParticleSystem explotionparticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpsound;
    public AudioClip crashsound;
    public float Jumpforce = 10;
    public float gravityModifier;
    public bool Ground = true;
    public bool gameover;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAN = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;

        // Update is called once per frame

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Ground&& !gameover)
            
        {
            playerRb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            Ground = false;
            playerAN.SetTrigger("jump");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpsound, 1.0f);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Ground = true;
            dirtParticle.Play();
        }
         if (collision.gameObject.CompareTag("obstackle"))
        {
            Debug.Log("gameover");
            gameover = true;
            playerAN.SetBool("Death_b", true);
            playerAN.SetInteger("Death_Type", 1);
            explotionparticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashsound, 1.0f);
        }
    }
}
