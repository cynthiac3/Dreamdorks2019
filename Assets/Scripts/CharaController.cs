using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Animator anim;

    public bool hasKeyGreen = false;
    public bool hasKeyPink = false;
    public bool hasKeyYellow = false;
    public bool hasKeyOrange = false;

    public bool hasDied = false;

    GameObject mSoundManager;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        mSoundManager = GameObject.Find("Soundmanager");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal") > 0.4)
        {
            anim.SetInteger("state", 2);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") < -0.4)
        {
            anim.SetInteger("state", 1);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetAxis("Vertical") < -0.4)
        {
            anim.SetInteger("state", 3);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetAxis("Vertical") > 0.4)
        {
            anim.SetInteger("state", 4);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (!Input.anyKey)
        {
            anim.SetInteger("state", 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.velocity *= -1;

        // Player is moved back to starting point
        if (other.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(112.48f, 17.52f, 37.5926f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        rb.velocity *= -1;
    }

    public void pickUpKey(string color)
    {

        mSoundManager.GetComponent<SoundManager>().playPickupSound();

        switch (color)
        {
            case "green":
                hasKeyGreen = true;
                break;
            case "pink":
                hasKeyPink = true;
                break;
            case "yellow":
                hasKeyYellow = true;
                break;
            case "orange":
                hasKeyOrange = true;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        // Player is moved back to starting point
        if (other.gameObject.tag == "Enemy")
        {
            mSoundManager.GetComponent<SoundManager>().playDie();
            hasDied = true;
            transform.position = new Vector3(78.52f, 21.02f, 43.1187f);
        }
    }
}
