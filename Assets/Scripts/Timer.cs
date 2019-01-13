using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeRemaining;
    float time = 10;

    public Image timer;
    public GameObject canvas;
    public GameObject Win;

    public bool isTimeOut;

    public GameObject right, wrong;

    public void ResetTimer()
    {
        time = 10;
        timeRemaining = time;
    }

    void UpdateTimer()
    {
        if (timeRemaining <= 0)
        {
            isTimeOut = true;
            //Debug.Log("TIME OUT");
            canvas.GetComponent<RandomQuestions>().getAnswer(canvas.GetComponent<RandomQuestions>().answer, " ");
            if (canvas.GetComponent<Health>().currentPlayerHP > 0)
            {
                canvas.GetComponent<Health>().GotHit();
                canvas.GetComponent<RandomQuestions>().getQuestion();
            }


        }
        else
        {
            timeRemaining -= Time.deltaTime;
            timer.fillAmount = timeRemaining / time;
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
        UpdateTimer();
    }
}
