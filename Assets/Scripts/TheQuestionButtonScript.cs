using TMPro;
using UnityEngine;

public class TheQuestionButtonScript : MonoBehaviour
{
    public Question data;

    [SerializeField] int whatStyle;

    ChoiceManager choiceManager;
    DialogManager dialogManager;
    DialogueCounterManager counterManager;

    void Start()
    {
        choiceManager = FindAnyObjectByType<ChoiceManager>();
        dialogManager = FindAnyObjectByType<DialogManager>();
    }

    public void SetValue(AnswerText réponse)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = data.variantes[GetTheVariante()];
        data.answer = réponse;
    }


    public void OnClick()
    {
        dialogManager.StartDialog(data.answer);
        choiceManager.AddTemporaryStats();
        counterManager.RemoveOneCredit();
    }

    int GetTheVariante()
    {
        if (choiceManager.stat1 > 2 && choiceManager.stat2! > 2 && choiceManager.stat3! > 2)
        { return 0; }

        if (choiceManager.stat1! > 2 && choiceManager.stat2 > 2 && choiceManager.stat3! > 2)
        { return 1; }

        if (choiceManager.stat1! > 2 && choiceManager.stat2! > 2 && choiceManager.stat3 > 2)
        { return 2; }

        if (choiceManager.stat1 > 2 && choiceManager.stat2 > 2 && choiceManager.stat3! > 2)
        { return 3; }

        if (choiceManager.stat1 > 2 && choiceManager.stat2! > 2 && choiceManager.stat3 > 2)
        { return 4; }

        if (choiceManager.stat1! > 2 && choiceManager.stat2 > 2 && choiceManager.stat3 > 2)
        { return 5; }

        if (choiceManager.stat1 > 2 && choiceManager.stat2 > 2 && choiceManager.stat3 > 2)
        { return 6; }

        if (choiceManager.stat1! > 2 && choiceManager.stat2! > 2 && choiceManager.stat3! > 2)
        { return 7; }

        return 69;
    }

}
