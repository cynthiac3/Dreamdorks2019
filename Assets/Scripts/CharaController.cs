using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour {
    public float speed;
    Rigidbody2D rb;
    Animator anim;

    public bool hasKeyGreen = false;
    public bool hasKeyPink = false;



	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        //var move = new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical"));
        //transform.position += move * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetInteger("state", 1);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetInteger("state", 2);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetInteger("state", 3);
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetInteger("state", 4);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (!Input.anyKey) {
            anim.SetInteger("state", 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.velocity *= -1;
    }

    private void OnTriggerStay(Collider other)
    {
        rb.velocity *= -1;
    }

    public void pickUpKey(string color) {
        switch (color) {
            case "green": hasKeyGreen = true;
                            break;
            case "pink":  hasKeyPink = true;
                            break;
        }
    }
}
