using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public string color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {



        /*
        switch (color) {

            case "pink": 
                               
            case "yellow":
            case "green":
        }
        if (other.gameObject.GetComponent<CharaController>().hasKeyGreen)
            Destroy(gameObject);
            */
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (color == "green")
        {
            if (other.gameObject.GetComponent<CharaController>().hasKeyGreen)
                Destroy(gameObject);
        }

    }
}
