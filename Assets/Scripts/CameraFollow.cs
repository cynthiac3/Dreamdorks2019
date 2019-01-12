using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Animator animator;

    public float sensitivityX = 5F;
    public float sensitivityY = 5F;


    public float minimumX = -90F;
    public float maximumX = 90F;


    public float minimumY = -45F;
    public float maximumY = 45F;


    float rotationY = 0F;
    float rotationX = 0f;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetAxis("Mouse X") * sensitivityX > 1 || Input.GetAxis("Mouse X") * sensitivityX < -1)
        {
            rotationX += Input.GetAxis("Mouse X") * sensitivityX;
            rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        }
        if (Input.GetAxis("Mouse Y") * sensitivityY > 1 || Input.GetAxis("Mouse Y") * sensitivityY < -1)
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        }

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);

        if (Input.GetAxis("Right Joystick") * sensitivityY < -1)
            animator.SetBool("isZooming", true);
        else if (Input.GetAxis("Right Joystick") * sensitivityY > 1)
            animator.SetBool("isZooming", false);
    }


}
