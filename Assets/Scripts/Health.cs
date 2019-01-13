using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {


    public Image playerHP;
    public Image teacherHP;

    public float currentTeacherHP;
    public float teacherHP_Max = 100;

    public float currentPlayerHP;
    public float playerHP_Max = 100;

    public GameObject Win;
    public GameObject Lose;

    public void ResetHP()
    {
        currentTeacherHP = 100;
        currentPlayerHP = 100;
    }
    void UpdateHP()
    {
        teacherHP.fillAmount = currentTeacherHP / teacherHP_Max;
        playerHP.fillAmount = currentPlayerHP / playerHP_Max;

    }

    public void AttackTeacher()
    {
        currentTeacherHP -= 200;
        if (currentTeacherHP <= 0)
            Win.GetComponent<WinLose>().SwitchGame(1);
            //Win.GetComponent<WinLose>().WinGame("boss");
  
    }

    public void GotHit()
    {
        currentPlayerHP -= 10;
        if (currentPlayerHP <= 0)
            Win.GetComponent<WinLose>().LoseGame();

    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        UpdateHP();
    }
}
