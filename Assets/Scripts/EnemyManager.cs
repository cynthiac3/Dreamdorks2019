using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    GameObject player;

    List<GameObject> enemies = new List<GameObject>();

    public float minSpeed;
    public float maxSpeed;

    public float timeUpdate = 5.0f;

    float timeCount;

    public float speedMultiplier = 0.1f;

    public bool gamePaused = true;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).tag == "Enemy")
                enemies.Add(transform.GetChild(i).gameObject);
        }
        timeCount =0.0f;
        player = GameObject.Find("chara");
	}
	
	// Update is called once per frame
	void Update () {
      
        if (!gamePaused)
        {
            timeCount += Time.deltaTime;

            if (timeCount >= timeUpdate) // enemies get faster
            {
                boostEnemies();
                timeCount = 0.0f;
            }

            if (player.GetComponent<CharaController>().hasDied) // enemies speed reset
            {
                slowEnemies();
                player.GetComponent<CharaController>().hasDied = false;
            }
        }

	}

    private void boostEnemies() {
        for (int i = 0; i < enemies.Count; i++)
        {
            if(enemies[i].GetComponent<Enemy>().walkSpeed < maxSpeed)
                enemies[i].GetComponent<Enemy>().walkSpeed += speedMultiplier;
        }
    }

    private void slowEnemies()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i].GetComponent<Enemy>().walkSpeed = minSpeed;
        }
    }

    public void bossTime() {
        GameObject.Find("Win").GetComponent<WinLose>().SwitchGame(0);
        speedMultiplier = 0.0f;
        gamePaused = true;
    }

    public void mazeTime() {
        speedMultiplier = 0.1f;
        gamePaused = false;
    }
}
