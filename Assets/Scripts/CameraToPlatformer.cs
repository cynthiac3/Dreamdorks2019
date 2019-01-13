using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToPlatformer : MonoBehaviour {


    Animator animator;
    Transform target;
    GameController gameController;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        //target = GameObject.FindGameObjectWithTag("PaperLevel").transform;
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
        // Switch to platformer
        if (Input.GetKey(KeyCode.U)) {
            animator.SetFloat("direction", 1.0f);
            animator.SetInteger("state", 1);
            gameController.setState(GameController.state.PLATFORMER);

        }
        // Switch to classroom
        if (Input.GetKey(KeyCode.I))
        {
            animator.SetFloat("direction", -1.0f);
            animator.SetInteger("state", 0);
            gameController.setState(GameController.state.BOSS);
        }

        /*
        if (Input.GetKey(KeyCode.J)){ 
            Vector3 pointOnside = target.position + new Vector3(target.localScale.x * 0.5f, 0.0f, target.localScale.z * 0.5f);
            float aspect = (float)Screen.width / (float)Screen.height;
            float maxDistance = (target.localScale.y * 0.5f) / Mathf.Tan(Mathf.Deg2Rad * (Camera.main.fieldOfView / aspect));
            Camera.main.transform.position = Vector3.MoveTowards(pointOnside, target.position, -maxDistance);
            Camera.main.transform.LookAt(target.position);
        }
        */
    }
}
