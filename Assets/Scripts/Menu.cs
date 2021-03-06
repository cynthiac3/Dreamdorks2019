﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject menu;
    public GameObject canvas;
    //public Animator animator;
    public GameObject cam;

    public GameObject intro;

    public GameObject Win;

    public GameObject GameOverScreen;
    public GameObject WinScreen;

    //public GameObject animFPS; ANIMATION SELON LE GAMEMODE


    public AudioSource buttonPress;

    public void buttonSound()
    {
        buttonPress.Play();
    }

    public void ReturnToMain()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    

    public void StartGame()
    {
        menu.GetComponent<XboxController>().enabled = false;
        cam.SetActive(true);
        cam.GetComponent<CameraFollow>().enabled = true;
        menu.SetActive(false);
        //canvas.SetActive(true);
        intro.GetComponent<Animation>().enabled = false;
        intro.SetActive(false);

        Win.GetComponent<WinLose>().SwitchGame(1);
        //animFPS.SetActive(true);
        //cam.GetComponent<Animator>().SetTrigger("MazeTrigger"); //Gamemode maze first

        //WaitTime(introClip);

        //jeu de maze commmence
    }
    /*
    void AnimeOver()
    {
            Debug.Log("anime done");
            //animator.SetBool("isZooming", false);
            cam.GetComponent<CameraFollow>().enabled = true;
            canvas.SetActive(true);
            menu.GetComponent<XboxController>().enabled = false;
    }
    */

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
        GameOverScreen.SetActive(false);
        WinScreen.SetActive(false);
        Debug.Log("RETURN");
        intro.SetActive(true);
        intro.GetComponent<Animation>().enabled = true;
        intro.GetComponent<Animation>().Play();
        menu.GetComponent<XboxController>().enabled = true;
        cam.GetComponent<CameraFollow>().enabled = false;
        menu.SetActive(true);
        canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		

	}
}
