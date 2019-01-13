using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject menu;
    public GameObject canvas;
    public Animator animator;
    public GameObject cam;

    public void StartGame()
    {
        animator.SetBool("isZooming", false);
        cam.GetComponent<CameraFollow>().enabled = true;
        menu.SetActive(false);
        canvas.SetActive(true);
        menu.GetComponent<XboxController>().enabled = false; ;
        //animation commence

        //jeu de maze commmence
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Credits()
    {
        Debug.Log("CREDITS");
        //credits canvas
    }

	// Use this for initialization
	void Start () {
        menu.GetComponent<XboxController>().enabled = true;
        cam.GetComponent<CameraFollow>().enabled = false;
        menu.SetActive(true);
        canvas.SetActive(false);
        animator.SetBool("isZooming", true);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
