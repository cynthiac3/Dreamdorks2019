using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    AudioSource[] AudioList;

	// Use this for initialization
	void Start () {
        AudioList = transform.GetComponents<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playPickupSound()
    {
        AudioList[0].Play();
    }

    public void playUnlockSound()
    {
        AudioList[1].Play();
    }

    public void playDie()
    {
        AudioList[2].Play();
    }

    public void playWin()
    {
        AudioList[3].Play();
    }
}
