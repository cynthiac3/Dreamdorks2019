using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuestions : MonoBehaviour
{
    public GameObject canvas;
    public Text questionText;
    public Text TextX;
    public Text TextY;
    public Text TextA;
    public Text TextB;

    public GameObject text3D;

    int numQuestions = 9;

    public string[][] MathQuestions = new string[10][];
    public string[][] GeoQuestions = new string[10][];
    public string[][] ScienceQuestions = new string[10][];
    public string[][] FrenchQuestions = new string[10][];

    public string answer;

    public void getQuestion(string[][] Subject)
    {
        string[][] subject;
        if (numQuestions >= 0)
        {
            int number = Random.Range(0, numQuestions);
            questionText.text = Subject[number][0];
            text3D.GetComponent<TextMesh>().text = Subject[number][0];

            TextX.text = Subject[number][1];
            TextY.text = Subject[number][2];
            TextA.text = Subject[number][3];
            TextB.text = Subject[number][4];

            answer = Subject[number][5];

            if (number < numQuestions)
                Subject[number] = Subject[numQuestions];
            numQuestions--;
        }
    }

    public bool getAnswer(string answer, string button)
    {
        if (button == answer)
            return true;
        else
            return false;
    }

    
    void generateQuestion()
    {
        MathQuestions[0] = new string[6] { "Quelle est la réponse de 6 fois 6?", "43", "24", "36", "66", "36" };
        MathQuestions[1] = new string[6] { "Quelle est la réponse de 7 - 20 + 43?", "30", "33", "29", "43", "30" };
        MathQuestions[2] = new string[6]{ "Quelle est la valeur de x si -x + 16 = 3x?", "3", "4", "2", "16", "4" };
        //A completer
        MathQuestions[3] = new string[6] { "Quelle est la réponse de 5 fois 5?", "43", "24", "36", "66", "36" };
        MathQuestions[4] = new string[6] { "Quelle est la réponse de 546?", "30", "33", "29", "43", "30" };
        MathQuestions[5] = new string[6] { "Quelle est la valeur deewrwer?", "3", "4", "2", "16", "4" };
        MathQuestions[6] = new string[6] { "Quelle est la réponse Oliver", "43", "24", "36", "66", "36" };
        MathQuestions[7] = new string[6] { "Quelle est la réponse de Celine?", "30", "33", "29", "43", "30" };
        MathQuestions[8] = new string[6] { "Quelle est la valeur de Helenea?", "3", "4", "2", "16", "4" };
        MathQuestions[9] = new string[6] { "Quelle est la valeur de Vitcor?", "3", "4", "2", "16", "4" };


        GeoQuestions[0] = new string[6] { "Quelle est le plus large continent du monde?", "Europe", "Asie", "Amerique du Nord", "Amerique du Sud", "Asie" };
        //A completer
        GeoQuestions[1] = new string[6] { "O", "test1", "test2", "test3", "test4", "test4" };
        GeoQuestions[2] = new string[6] { "a", "b", "c", "d", "e", "d" };
        GeoQuestions[3] = new string[6] { "Quelle est le plus large continent du monde?", "Europe", "Asie", "Amerique du Nord", "Amerique du Sud", "Asie" };
        GeoQuestions[4] = new string[6] { "O", "test1", "test2", "test3", "test4", "test4" };
        GeoQuestions[5] = new string[6] { "a", "b", "c", "d", "e", "d" };
        GeoQuestions[6] = new string[6] { "Quelle est le plus large continent du monde?", "Europe", "Asie", "Amerique du Nord", "Amerique du Sud", "Asie" };
        GeoQuestions[7] = new string[6] { "O", "test1", "test2", "test3", "test4", "test4" };
        GeoQuestions[8] = new string[6] { "a", "b", "c", "d", "e", "d" };
        GeoQuestions[9] = new string[6] { "a", "b", "c", "d", "e", "d" };


        //A completer
        ScienceQuestions[0] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[1] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[2] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[3] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[4] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[5] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[6] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[7] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[8] = new string[6] { "", "", "", "", "", "" };
        ScienceQuestions[9] = new string[6] { "", "", "", "", "", "" };

        //A completer
        FrenchQuestions[0] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[1] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[3] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[4] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[5] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[6] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[7] = new string[6] { "", "", "", "", "", "" };
        FrenchQuestions[8] = new string[6] { "", "", "", "", "", "" };


    }

    void Start()
    {
        generateQuestion();
        getQuestion(MathQuestions);


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            getQuestion(MathQuestions);
    }
}



