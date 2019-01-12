using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float timeRemaining;

    float time = 10;

    public Image timer;

    public void resetTime()
    {

        time = 10;
        timeRemaining = time;
    }

    void updateTimer()
    {
        if (timeRemaining <= 0)
        {
            Debug.Log("TIME OUT");
        }
        else
        {
            //timer.GetComponentInChildren<Text>().text = "Temps Restant: " + Mathf.Round(timeRemaining);
            timeRemaining -= Time.deltaTime;
            timer.fillAmount = timeRemaining / time;
            Debug.Log(timeRemaining);
        }
    }

    // Use this for initialization
    void Start()
    {
        timeRemaining = time;
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer();
        if (Input.anyKeyDown)
            resetTime();
    }
}
