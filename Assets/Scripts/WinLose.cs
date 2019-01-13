using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour {

    public int mazeGame = 0;
    public int bossGame = 1;

    public GameObject Detention;
    public GameObject SchoolsOut;
    public GameObject canvas;
    public Animator animator;
    public GameObject cam;

    public void EndWin()
    {
        cam.GetComponent<CameraFollow>().enabled = false;
        SchoolsOut.SetActive(true);
        canvas.SetActive(false);
        Debug.Log("WIN");
    }

    public void WinGame(string game)
    {
        if (game == "boss")
        {
            bossGame++;
            if (bossGame == 2)
            {
                EndWin();
            }
            //else animation to maze
        }
        else mazeGame++;
        //animation
        if (mazeGame == 1)
        {
            //setactive level1
        }//else setactive level2


    }

    public void LoseGame()
    {
        cam.GetComponent<CameraFollow>().enabled = false;
        Detention.SetActive(true);
        canvas.SetActive(false);
        
        Debug.Log("LOSE");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
