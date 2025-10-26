using TMPro;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    [SerializeField] bool[] ligne1 = new bool[5], ligne2 = new bool[5], ligne3 = new bool[5];
    public int stat1, stat2 , stat3;
    public GameObject[] boutonsQuestion;

    public int temporaryStat;
    [SerializeField] DataPerso speakingWith;


    public void SetPersonSpeaking(DataPerso person) { speakingWith = person; temporaryStat = speakingWith.whatStyle; }

    public void AddTemporaryStats()
    {
        if (temporaryStat == 1) { stat1 += 2; }
        if (temporaryStat == 2) { stat2 += 2; }
        if (temporaryStat == 3) { stat3 += 2; }
    }


    public void ChangeQuestion()
    {   
        int colonne = 0;
        CalculStats();
        foreach (GameObject go in boutonsQuestion)
        {
            if (colonne < boutonsQuestion.Length)
            {   //tema la taille de la ligne
                go.GetComponentInChildren<TextMeshProUGUI>().text = speakingWith.questions[colonne].variantes[GetTheQuestionVar(ligne1[colonne], ligne2[colonne], ligne3[colonne])];
                go.GetComponent<ButtonScript>().SetRefQuestion(speakingWith.questions[colonne].answer, GetTheQuestionVar(ligne1[colonne], ligne2[colonne], ligne3[colonne]));
            }
            colonne++;
        }
    }

    public void ReverseTemporary()
    {
        if (temporaryStat == 1) { stat1 -= 1; }
        if (temporaryStat == 2) { stat2 -= 1; }
        if (temporaryStat == 3) { stat3 -= 1; }
    }


    int GetTheQuestionVar(bool style1, bool style2, bool style3)
    {
        if (style1&& !style2 && !style3)
        {
            return 0;
        }
        if (!style1 && style2 && !style3)
        {
            return 1;
        }
        if (!style1 && !style2 && style3)
        {
            return 2;
        }
        if (style1 && style2 && !style3)
        { return 3; }

        if (style1 && !style2 && style3)
        { return 4; }

        if (!style1 && style2 && style3)
        { return 5; }

        if (style1 && style2 && style3)
        { return 6; }

        if (!style1 && !style2 && !style3)
        { return 7; }

        return 69; //normalement il est pas utilisé hein
    }


    //plus personne y touche merci
    void CalculStats()
    {   
        int stats1 = stat1, stats2 = stat2, stats3 = stat3;
        int divstat1, divstat2;
        int i1 = 0, i2 = 2, i3 = 4;


        //envie de crever en voyant ça ? moi aussi
        foreach (bool b in ligne1)
        { ligne1[i1] = stats1 > 0 ? true : false; stats1--; i1++; }


        if (stats2%2 == 1) { ligne2[i2] = true; stats2 -= 1; }
        else if (stats2%2 == 0) { ligne2[i2] = false; }

        divstat1 = stat2 / 2;
        divstat2 = divstat1;
        divstat1 -= 1;

        for (int i = 0; i<2;) {
            ligne2[i] = divstat1 > 0 ? true : false;
            divstat1++; i++;
        }
        for (int i = 3; i < 5;) {
            ligne2[i] = divstat2 > 0 ? true : false;
            divstat2--; i++;
        }


        foreach (bool b in ligne3)
        { ligne3[i3] = stats3 > 0 ? true : false; stats3 --; i3--;}

    }
}
