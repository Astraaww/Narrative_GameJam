using UnityEngine;
using TMPro;

public class DialogueCounterManager : MonoBehaviour
{
    public int creditDialogue = 10;

    [SerializeField] GameObject dialoguePanel;
    [SerializeField] TextMeshProUGUI counterTextBox;
    [SerializeField] GameObject choicePanel;

    void Start()
    {
        counterTextBox.text = new string("Crédits Dilogues : " + creditDialogue);
    }

    public void RemoveOneCredit()
    {
        creditDialogue--;
        counterTextBox.text = new string("Crédits Dilogues : " + creditDialogue);
    }

    void Update()
    {
        if (dialoguePanel.activeSelf)
        {
            counterTextBox.rectTransform.anchoredPosition = new Vector3(-778f, 0f, 0f);
        }
        else if(choicePanel.activeSelf)
        {
            counterTextBox.rectTransform.anchoredPosition = new Vector3(-809f, 450f, 0f);
        }
        else
        {
            counterTextBox.rectTransform.anchoredPosition = new Vector3(10000f, 100000f, 0f);
        }

    }
}
