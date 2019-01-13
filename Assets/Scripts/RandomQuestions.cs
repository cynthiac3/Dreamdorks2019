using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuestions : MonoBehaviour
{
    public GameObject canvas;
    public Image leftTimer, rightTimer;

    public Text questionText;
    public Text TextX;
    public Text TextY;
    public Text TextA;
    public Text TextB;

    public GameObject text3D;
    public GameObject gm;

    public GameObject teacher;

    public GameObject right, wrong;
    //public AnimationClip righClipOut, wrongClipOut;


    //public int bossFight = 0;
    public int numQuestions = 40;

    /*
    public string[][] MathQuestions = new string[10][];
    public string[][] GeoQuestions = new string[10][];
    public string[][] ScienceQuestions = new string[10][];
    public string[][] FrenchQuestions = new string[10][];
    */
    public string[][] Questions = new string[40][];

    public string answer;


    public void getQuestion()
    {
        //string[][] Subject = null;
        /*
        if (numBossFight == 0)
        {
            Subject = MathQuestions;
        }
        else if(numBossFight == 1)
        {
            Subject = GeoQuestions;
        }
        else if (numBossFight == 2)
        {
            Subject = ScienceQuestions;
        }
        else if (numBossFight == 3)
        {
            Subject = FrenchQuestions;
        }
        */
        if (numQuestions >= 0)
        {
            int number = Random.Range(0, numQuestions);
            questionText.text = Questions[number][0];
            text3D.GetComponent<TextMesh>().text = Questions[number][0];

            TextX.text = Questions[number][1];
            TextY.text = Questions[number][2];
            TextA.text = Questions[number][3];
            TextB.text = Questions[number][4];

            answer = Questions[number][5];

            if (number < numQuestions)
                Questions[number] = Questions[numQuestions - 1];
            numQuestions--;
        }
    }

    public bool getAnswer(string answer, string button)
    {
        leftTimer.GetComponent<Timer>().ResetTimer();
        rightTimer.GetComponent<Timer>().ResetTimer();

        if (button == answer)
        {
            teacher.GetComponent<Animator>().SetTrigger("RightAnswer");
            wrong.SetActive(false);
            right.SetActive(true);
            right.GetComponent<Animator>().SetTrigger("FadeTrigger");
           // if (right.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !right.GetComponent<Animator>().IsInTransition(0))
                //right.SetActive(false);
            return true;
        }
        else
        {
            teacher.GetComponent<Animator>().SetTrigger("WrongAnswer");
            right.SetActive(false);
            wrong.SetActive(true);
            wrong.GetComponent<Animator>().SetTrigger("FadeTrigger");
            //if (wrong.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !wrong.GetComponent<Animator>().IsInTransition(0))
                //wrong.SetActive(false);
            return false;
        }
    }

    
    void generateQuestion()
    {
        Questions[0] = new string[6] { "Que vaut 6 fois 6?", "43", "24", "36", "66", "36" };
        Questions[1] = new string[6] { "Quelle est la réponse de\n 7 - 20 + 43?", "30", "33", "29", "43", "30" };
        Questions[2] = new string[6] { "Quelle est la valeur de\n x si -x + 16 = 3x?", "3", "4", "2", "16", "4" };
        Questions[3] = new string[6] { "Quelle est la réponse de\n 5 fois 13?", "23", "24", "65", "66", "65" };
        Questions[4] = new string[6] { "Quelle est l’aire d’un\n rectangle 1.3 par 9?", "11.7", "11.0", "12.1", "11.9", "11.7" };
        Questions[5] = new string[6] { "Quelle est la circonférence\n d’un cercle de rayon 10?", "36" + Mathf.PI, "20" + Mathf.PI, "16" + Mathf.PI, "45" + Mathf.PI, "20" + Mathf.PI };
        Questions[6] = new string[6] { "Quelle est l’aire d’un cercle\n de rayon 3?", "9", "9" + Mathf.PI, "3" + Mathf.PI, "3", "9" + Mathf.PI };
        Questions[7] = new string[6] { "Combien il y a-t-il\n d'étudiants dans la classe?", "5", "4", "3", "6", "5" };
        Questions[8] = new string[6] { "Quelle est la dérivée de\n 3x^2 + x - 9?", "6x^2 + 1", "3x + 1", "7", "6x + 1", "6x + 1" };
        Questions[9] = new string[6] { "Que vaut 32°F en\n degrés Celsius?", "23", "0", "10", "31", "0" };



        Questions[10] = new string[6] { "Quelle est le plus large\n continent du monde?", "Europe", "Asie", "Amerique du Nord", "Amerique du Sud", "Asie" };
        Questions[11] = new string[6] { "Quel pays a les lacs\n les plus naturels?", "Canada", "Russie", "États-Unis", "Australie", "Canada" };
        Questions[12] = new string[6] { "Quelle rivière traverse\n Bagdad?", "Karun", "Jordan", "Tigris", "le Nile", "Tigris" };
        Questions[13] = new string[6] { "Quelle est le plus large\n pays du monde?", "Canada", "la Chine", "la Russie", "les États-Unis", "la Russie" };
        Questions[14] = new string[6] { "Dans quel pays pouvez-vous\n visiter le Machu Picchu?", "Pérou", "Bolivie", "Colombie", "Egypte", "Pérou" };
        Questions[15] = new string[6] { "Quel est le seul continent\n possédant des terres dans\n les quatre hémisphères?", "Amérique du Nord", "Asie", "Amérique du Sud", "Afrique", "Afrique" };
        Questions[16] = new string[6] { "Quelle est la plus vieille\n ville du monde?", "Jérusalem", "Damas", "Athènes", "Jéricho", "Jéricho" };
        Questions[17] = new string[6] { "Dans quel pays se situe\n l'île Kangourou?", "l’Australie", "Canada", "Japon", "la Chine", "l’Australie" };
        Questions[18] = new string[6] { "Quelle est la plus haute\n montagne du monde?", "Qogir", "Mont St Bruno", "le Mont Kilimanjaro", "Mont Everest", "Mont Everest" };
        Questions[19] = new string[6] { "Quel est le plus grand pays\n d'Amérique du Sud?", "Brésil", "Argentine", "Colombie", "Pérou", "Brésil" };



        Questions[20] = new string[6] { "Comment le nombre décimal 21\n est-il représenté en binaire?", "10110", "10101", "10111", "11000", "10101" };
        Questions[21] = new string[6] { "Combien de temps faut-il\n pour que la lumière du Soleil\n atteigne la Terre?", "8 minutes", "7 minutes 20 secondes", "8 minutes 20 secondes", "9 minutes", "8 minutes 20 secondes" };
        Questions[22] = new string[6] { "Quel est le premier élément\n du tableau périodique?", "Oxygène", "Hydrogène", "Fer", "Hélium", "Hydrogène" };
        Questions[23] = new string[6] { "Quel est le symbole chimique\n pour le sel de table?", "Na", "Cl2", "O2", "NaCl", "NaCl" };
        Questions[24] = new string[6] { "À quelle température Celsius\n et Fahrenheit sont-ils égaux?", "40", "-40", "0", "100", "-40" };
        Questions[25] = new string[6] { "Où le son voyage-t-il\n plus vite?", "Eau", "Air", "Pudding", "Sirop d’érable", "Eau" };
        Questions[26] = new string[6] { "Quelle planète a le\n plus de lunes?", "Jupitre", "La lune", "Vénus", "Terre", "Jupitre" };
        Questions[27] = new string[6] { "Une tomate est ___.", "Une sorte de pain", "Un légume", "Un fruit", "de la viande", "Un fruit" };
        Questions[28] = new string[6] { "Quelle forme est la terre?", "Un disque", "Une sphère", "Un cercle", "Un triangle", "Une sphère" };
        Questions[29] = new string[6] { "Pluton est ___.", "une planète", "une lune", "vivant", "une planète naine", "une planète naine" };


        Questions[30] = new string[6] { "Quel est le pluriel de\n « gratte-ciel »?", "grattes-ciels", "gratte-cieux", "grattes-ciel", "gratte-ciels", "grattes-ciel" };
        Questions[31] = new string[6] { "Conjuguez le verbe \"croître\" à\n la 1ère personne du singulier\n du passé simple de l’indicatif.", "Je crûs", "Je crois", "Je croîtrais", "Je crû", "Je crûs" };
        Questions[32] = new string[6] { "Conjuguez le verbe \"avoir\" à\n la 3ème personne du singulier\n au présent de l’indicatif.", "Il as", "Il a", "J'ai", "Ils ont", "Il a" };
        Questions[33] = new string[6] { "Lequel parmi ces mots n'est\n pas une préposition?", "car", "vers", "avant", "dans", "car" };
        Questions[34] = new string[6] { "Quel est le genre et\n le nombre du mot « avion »?", "Masculin, pluriel", "Masculin, singulier", "Féminin, pluriel", "Féminin, singulier", "Masculin, singulier" };
        Questions[35] = new string[6] { "Je dois acheter ____ romans\n pour ma soeur. ", "une", "un", "la", "des", "des" };
        Questions[36] = new string[6] { "Je vais chez ____ uncle\n et ma tante.", "m'ont", "mont", "mon", "monts", "mon" };
        Questions[37] = new string[6] { "L'origine de la langue\n française est ____.", "celtique", "romane", "germanique", "slave", "romane" };
        Questions[38] = new string[6] { "La venue de cet enfant\n est un heureux ____.", "événement", "avènement", "avanement", "èvènement", "événement" };
        Questions[39] = new string[6] { "Les ordinateurs actuels\n _____ moins d'énergie.", "consomme", "consommes", "consoment", "consomment", "consomment" };


    }

    void Start()
    {
        generateQuestion();
        getQuestion();
        gm.GetComponent<WinLose>().isMazing = false;

    }

    void Update()
    {
        if (right.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !right.GetComponent<Animator>().IsInTransition(0))
            right.SetActive(false);
        if (wrong.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !wrong.GetComponent<Animator>().IsInTransition(0))
            wrong.SetActive(false);
    }
}



