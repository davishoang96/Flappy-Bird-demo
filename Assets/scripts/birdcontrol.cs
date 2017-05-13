using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdcontrol : MonoBehaviour {

    public float bounceForce;
    private Rigidbody2D myBody;
    private Animator anim;

    private bool isAlive;
    private bool didFlap;

    [SerializeField] //
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip flyClip, pingClip, diedClip;

	// Use this for initialization
	void Awake () {
        isAlive = true;

		myBody = GetComponent<Rigidbody2D> ();

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        BirdMovement();
	}

    void BirdMovement()
    {
        if(isAlive == true)
        {
            if(didFlap)
            {
                didFlap = false;
                myBody.velocity = new Vector2(myBody.velocity.x, bounceForce);
                audioSource.PlayOneShot(flyClip);
            }
        }

        if (myBody.velocity.y > 0)
        {
            float angel = Mathf.Lerp(0, 45, myBody.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angel);
        } 
        else if (myBody.velocity.y == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (myBody.velocity.y < 0)
        {
            float angel = Mathf.Lerp(0, -45, -myBody.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angel);
        }
    }

    public void FlapButton()
    {
        didFlap = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "pipeHolder")
        {
            audioSource.PlayOneShot(pingClip);
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "pipe" || target.gameObject.tag == "ground")
        {
            anim.SetTrigger("died");
            audioSource.PlayOneShot(diedClip);
        }
    }
}
