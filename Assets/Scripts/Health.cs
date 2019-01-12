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

    void UpdateHP()
    {
        teacherHP.fillAmount = currentTeacherHP / teacherHP_Max;
        playerHP.fillAmount = currentPlayerHP / playerHP_Max;

    }

    public void AttackTeacher()
    {
        Debug.Log("You attacked the teacher!");
        currentTeacherHP -= 20;
    }

    public void GotHit()
    {
        Debug.Log("You got hit!");
        currentPlayerHP -= 10;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UpdateHP();
    }
}
