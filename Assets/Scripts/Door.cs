using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public string color;

    GameObject mSoundManager;

    // Use this for initialization
    void Start()
    {
        mSoundManager = GameObject.Find("Soundmanager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {



        /*
        switch (color) {

            case "pink": 
                               
            case "yellow":
            case "green":
        }
        if (other.gameObject.GetComponent<CharaController>().hasKeyGreen)
            Destroy(gameObject);
            */
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (color == "green")
        {
            if (other.gameObject.GetComponent<CharaController>().hasKeyGreen)
            {
                mSoundManager.GetComponent<SoundManager>().playUnlockSound();
                Destroy(gameObject);
            }
        }
        else if (color == "pink")
        {
            if (other.gameObject.GetComponent<CharaController>().hasKeyPink)
            {
                mSoundManager.GetComponent<SoundManager>().playUnlockSound();
                Destroy(gameObject);
            }
        }
        else if (color == "yellow")
        {
            if (other.gameObject.GetComponent<CharaController>().hasKeyYellow)
            {
                mSoundManager.GetComponent<SoundManager>().playUnlockSound();
                GameObject.Find("Enemies").GetComponent<EnemyManager>().bossTime();
                Destroy(gameObject);

            }
        }
        else if (color == "orange")
        {
            if (other.gameObject.GetComponent<CharaController>().hasKeyOrange)
            {
                mSoundManager.GetComponent<SoundManager>().playUnlockSound();
                Destroy(gameObject);
            }
        }
        else if (color == "final")
        {
            mSoundManager.GetComponent<SoundManager>().playWin();
            GameObject.Find("Enemies").GetComponent<EnemyManager>().bossTime();
            Destroy(gameObject);
        }

    }
}
