using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public string color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Inside function");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Inside function- if");
            other.gameObject.GetComponent<CharaController>().pickUpKey(color);
            Destroy(gameObject);
        }
    }

}
