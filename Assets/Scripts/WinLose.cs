using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour {



    public int mazeGame = 0;
    public int bossGame = 0;

    public GameObject Detention;
    public GameObject SchoolsOut;
    public GameObject canvas;
    public Animator animator;
    public GameObject cam;

    public Animator gameMode;

    public GameObject menu;

    public bool isMazing = false;

    public void EndWin()
    {
        cam.GetComponent<CameraFollow>().enabled = false;
        SchoolsOut.SetActive(true);
        canvas.SetActive(false);
        menu.GetComponent<Menu>().WinScreen.SetActive(true);
    }

    public int CurrentGame()
    {
        if (isMazing)
            return 1;
        else
            return 0;
    }

    public void SwitchGame(int mode)
    {
        if(mode == 1) // switching to mode 1 -> Maze //!!changer le nb dans bossGame et mazeGame
        {
            bossGame++;
            if (bossGame == 3)
            {
                EndWin(); //End of the game
            }
            else
            {
                gameMode.SetTrigger("MazeTrigger");
                canvas.SetActive(false);
                isMazing = true;
                
            }
        }
        else if(mode == 0) // switching to mode 0 -> BossFight
        {
            mazeGame++;
            gameMode.SetTrigger("BossTrigger");
            canvas.SetActive(true);
            isMazing = false;
            canvas.GetComponent<Health>().ResetHP();
        }

        if (mazeGame == 1)
        {
            //setactive level1
        }
        //else setactive level2

    }

    public void WinGame(string game)
    {
        if (game == "boss") //BossFight gamemode
        {
            bossGame++;
            if (bossGame == 2)
            {
                EndWin(); //End of the game
            }

        }
        else
        {
            mazeGame++;
            gameMode.SetTrigger("BossTrigger");
        }
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
        menu.GetComponent<Menu>().GameOverScreen.SetActive(true);
        Debug.Log("LOSE");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //TESTING -- A ENLEVER APRES L'AJOUT DU MAZE
        if(CurrentGame() == 1)
            if (Input.GetKey(KeyCode.A))
                SwitchGame(0);
    }
}
