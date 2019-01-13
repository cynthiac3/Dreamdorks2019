using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public enum state { MENU, PLATFORMER, BOSS, GAMEOVER }

    public state currentState;
    public int levelNum;
    public int bossNum;

    GameObject bossUI;


	// Use this for initialization
	void Start () {
        currentState = state.BOSS;
        levelNum = 1;
        bossNum = 1;
        bossUI = GameObject.FindGameObjectWithTag("BossUI");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setState(state newState) {
        currentState = newState;

        if (currentState == state.BOSS) {
            //bossUI.SetActive(true);
        } else if (currentState == state.PLATFORMER) {
            //bossUI.SetActive(false);
        }

    }
}
