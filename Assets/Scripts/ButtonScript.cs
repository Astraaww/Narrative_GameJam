using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    DialogManager manager;
    ChoiceManager choiceManager;
    DialogueCounterManager counterManager;

    [Header("Character")]
    [SerializeField] private bool CharaButton;
    [SerializeField] DataPerso perso;
    
    [Header("Question")]
    [SerializeField] private bool QuestionButton;
    int questionStyle;
    bool hasClicked;
    AnswerText réponse;

    void Start()
    {
        manager = FindAnyObjectByType<DialogManager>();
        choiceManager = FindAnyObjectByType<ChoiceManager>();
        counterManager = FindAnyObjectByType<DialogueCounterManager>();
    }

    public void SetRefQuestion(AnswerText dialog, int style)
    { 
        réponse = dialog;
        questionStyle = style;
    }

    public void OnClick()
    {
        if (CharaButton)
        {
            if (counterManager.creditDialogue > 0)
            {
                choiceManager.SetPersonSpeaking(perso);
                manager.SetSpeed(perso.textSpeed);
            }
            else { }//gneuh gneuh tu peux pas pcq pas de credit bouuuuh
        }
        if (QuestionButton) 
        {
            if (counterManager.creditDialogue > 0)
            {
                AddPermaStat();
                manager.StartDialog(réponse);
                hasClicked = true;
                gameObject.GetComponent<Button>().enabled = !hasClicked;
                gameObject.SetActive(!hasClicked);
                counterManager.RemoveOneCredit();
            }
            else { } //gneuh gneuh tu peux pas
        }
    }

    void AddPermaStat()
    {
        switch (questionStyle)
        {
            case 0:
                choiceManager.stat1 += 1; break;
            case 1:
                choiceManager.stat2 += 1; break;
            case 2:
                choiceManager.stat3 += 1; break;
            case 3:
                choiceManager.stat1 += 1; choiceManager.stat2 += 1; break;
            case 4:
                choiceManager.stat1 += 1; choiceManager.stat3 += 1; break;
            case 5:
                choiceManager.stat2 += 1; choiceManager.stat3 += 1; break;
            case 6:
                choiceManager.stat1 += 1; choiceManager.stat2 += 1; choiceManager.stat3 += 1; break;
            default:
                break;
        }
    }
}
