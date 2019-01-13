using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Where is the player
    private Transform playerTransform;

    bool chasing = false;
    bool waiting = false;
    private float distanceFromTarget;
    public bool inViewCone;
    public bool dir;

    // Where is it going and how fast?
    Vector3 direction;
    private float walkSpeed = 0.4f;
    public int currentTarget;

    public Transform[] navPoints;
    public float speed = 0.4f;

    // Use this for initialization
    void Start () {
        // Get a reference to the player's transform
        playerTransform = GameObject.Find("chara").transform;

        transform.position = navPoints[0].position;
        currentTarget = 0;
        dir = true;
        direction = navPoints[currentTarget].position - transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        // If chasing get the position of the player and point towards it
        if (chasing)
        {
            direction = playerTransform.position - transform.position;
            direction = direction.normalized;
        }

        // Unless the zombie is waiting then move
        if (!waiting)
        {
            transform.Translate(walkSpeed * direction * Time.deltaTime, Space.World);
        }
    }

    private void FixedUpdate() {
        // Give the values to the FSM (animator)
        distanceFromTarget = Vector3.Distance(navPoints[currentTarget].position, transform.position);
    }

    public void SetNextPoint()
    {
        /*
        Debug.Log("Current target = " + currentTarget);
        if (currentTarget == navPoints.Length - 1)
            currentTarget = 0;
        if (currentTarget == 0)
            dir = true;

        if (dir)
            currentTarget++;
        else
            currentTarget--;
        Debug.Log("Current target2 = " + currentTarget);
        // Load the direction of the next waypoint
        direction = navPoints[currentTarget].position - transform.position;
        */
        if (currentTarget == navPoints.Length - 1)
            currentTarget = 0;
        else
            currentTarget++;

        direction = navPoints[currentTarget].position - transform.position;
    }

    public void StartChasing()
    {
        chasing = true;
    }

    public void ToggleWaiting()
    {
        waiting = !waiting;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NavPoint") {
            Debug.Log("Collision with navpoint");
            SetNextPoint();
        }
    }
}
