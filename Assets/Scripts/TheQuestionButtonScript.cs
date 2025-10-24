using TMPro;
using UnityEngine;

public class TheQuestionButtonScript : MonoBehaviour
{
    public Question data;

    [SerializeField] int whatStyle;

    ChoiceManager choiceManager;
    DialogManager dialogManager;

    void Start()
    {
        choiceManager = FindAnyObjectByType<ChoiceManager>();
        dialogManager = FindAnyObjectByType<DialogManager>();
    }

    public void SetValue(AnswerText r�ponse)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = data.variantes[GetTheVariante()];
        data.answer = r�ponse;
    }


    public void OnClick()
    {
        dialogManager.StartDialog(data.answer);
        choiceManager.AddTemporaryStats();
    }

    int GetTheVariante()
    {
        if (choiceManager.stat1 > 4 && choiceManager.stat2! > 4 && choiceManager.stat3! > 4)
        { return 0; }

        if (choiceManager.stat1! > 4 && choiceManager.stat2 > 4 && choiceManager.stat3! > 4)
        { return 1; }

        if (choiceManager.stat1! > 4 && choiceManager.stat2! > 4 && choiceManager.stat3 > 4)
        { return 2; }

        if (choiceManager.stat1 > 4 && choiceManager.stat2 > 4 && choiceManager.stat3! > 4)
        { return 3; }

        if (choiceManager.stat1 > 4 && choiceManager.stat2! > 4 && choiceManager.stat3 > 4)
        { return 4; }

        if (choiceManager.stat1! > 4 && choiceManager.stat2 > 4 && choiceManager.stat3 > 4)
        { return 5; }

        if (choiceManager.stat1 > 4 && choiceManager.stat2 > 4 && choiceManager.stat3 > 4)
        { return 6; }

        if (choiceManager.stat1! > 4 && choiceManager.stat2! > 4 && choiceManager.stat3! > 4)
        { return 7; }

        return 69;
    }

}
