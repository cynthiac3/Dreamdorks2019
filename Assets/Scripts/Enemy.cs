using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Where is the player
    private Transform playerTransform;

    bool chasing = false;
    bool waiting = false;
    private float distanceFromTarget;
    public bool inViewCone;
    public bool odd;
    private bool reverse = false;

    // Where is it going and how fast?
    Vector3 direction;
    public float walkSpeed = 0.4f;
    public int currentTarget;

    public Transform[] navPoints;
    // public float speed = 0.4f;

    // Use this for initialization
    void Start()
    {
        // Get a reference to the player's transform
        playerTransform = GameObject.Find("chara").transform;

        transform.position = navPoints[0].position;
        currentTarget = 0;
        direction = navPoints[currentTarget].position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

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

    private void FixedUpdate()
    {
        // Give the values to the FSM (animator)
        distanceFromTarget = Vector3.Distance(navPoints[currentTarget].position, transform.position);
    }

    public void SetNextPoint()
    {
        if (!odd)
        {
            if (currentTarget == navPoints.Length - 1)
                currentTarget = 0;
            else
                currentTarget++;
        }
        else
        {
            if (currentTarget == navPoints.Length - 1)
                reverse = true;
            if (currentTarget == 0)
                reverse = false;

            if (!reverse)
                currentTarget++;
            else
                currentTarget--;
        }

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "NavPoint")
        {
            SetNextPoint();
        }
    }
}
