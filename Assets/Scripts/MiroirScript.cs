using TMPro;
using UnityEngine;

public class MiroirScript : MonoBehaviour
{
    DialogueCounterManager manager;
    ChoiceManager choiceManager;
    [SerializeField] Sprite[] spritesData;
    Sprite useSprite;
    [SerializeField] Question TheLastQuest;
    [SerializeField] TextMeshProUGUI textBox;

    void Start()
    {
        manager = FindAnyObjectByType<DialogueCounterManager>();
        choiceManager = FindAnyObjectByType<ChoiceManager>();
    }

    public void OnClick()
    {
        if (CanContinue()) { CalculateEnd(); } // sorte d'anim avec apparition du sprite (useSprite) avec préalablement un dialogue de la porte ?
        else { } //tu te fais rembarer

    }

    bool CanContinue()
    {
        if (manager.creditDialogue == 0)
            return true;

        return false;
    }






    //enlevez ça de ma vue
    void CalculateEnd()
    {
        if (choiceManager.stat1 > 3 && choiceManager.stat2! > 3 && choiceManager.stat3! > 3)
        { textBox.text =  TheLastQuest.variantes[0]; useSprite = spritesData[0]; }

        if (choiceManager.stat1! > 3 && choiceManager.stat2 > 3 && choiceManager.stat3! > 3)
        { textBox.text = TheLastQuest.variantes[1]; useSprite = spritesData[1]; }

        if (choiceManager.stat1! > 3 && choiceManager.stat2! > 3 && choiceManager.stat3 > 3)
        { textBox.text = TheLastQuest.variantes[2]; useSprite = spritesData[2]; }

        if (choiceManager.stat1 > 3 && choiceManager.stat2 > 3 && choiceManager.stat3! > 3)
        { textBox.text = TheLastQuest.variantes[3]; useSprite = spritesData[3]; }

        if (choiceManager.stat1 > 3 && choiceManager.stat2! > 3 && choiceManager.stat3 > 3)
        { textBox.text = TheLastQuest.variantes[4]; useSprite = spritesData[4]; }

        if (choiceManager.stat1! > 3 && choiceManager.stat2 > 3 && choiceManager.stat3 > 3)
        { textBox.text = TheLastQuest.variantes[5]; useSprite = spritesData[5]; }

        if (choiceManager.stat1 > 3 && choiceManager.stat2 > 3 && choiceManager.stat3 > 3)
        { textBox.text = TheLastQuest.variantes[6]; useSprite = spritesData[6]; }

        if (choiceManager.stat1! > 3 && choiceManager.stat2! > 3 && choiceManager.stat3! > 3)
        { textBox.text = TheLastQuest.variantes[7]; useSprite = spritesData[7]; }

    }
}
