using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiroirScript : MonoBehaviour
{
    DialogueCounterManager manager;
    ChoiceManager choiceManager;
    [SerializeField] Sprite[] spritesData;
    Sprite useSprite;
    [SerializeField] Question TheLastQuest;
    [SerializeField] TextMeshProUGUI textBox;
    [SerializeField] GameObject image;
    bool hastimer;
    float time;
    int indexTimer = 0;

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

    public void SetTimer()
    {
        hastimer = true;
    }

    bool CanContinue()
    {
        if (manager.creditDialogue <= 0)
            return true;

        return false;
    }

    private void Update()
    {
        if (hastimer && indexTimer == 0) { 
            if (time < 3) { time += Time.deltaTime; } 
            else { 
                image.GetComponent<Image>().sprite = useSprite;
                image.SetActive(true);
                time = 0;
                indexTimer++;
            } 
        }

        if (hastimer && indexTimer == 1)
        {
            if (time < 5) { time += Time.deltaTime; }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }



    //enlevez ça de ma vue
    void CalculateEnd()
    {
        if (choiceManager.stat1 >= 3 && choiceManager.stat2 < 3 && choiceManager.stat3 < 3)
        { textBox.text =  TheLastQuest.variantes[0]; useSprite = spritesData[0]; }

        if (choiceManager.stat1 < 3 && choiceManager.stat2 >= 3 && choiceManager.stat3 < 3)
        { textBox.text = TheLastQuest.variantes[1]; useSprite = spritesData[1]; }

        if (choiceManager.stat1 < 3 && choiceManager.stat2 < 3 && choiceManager.stat3 >= 3)
        { textBox.text = TheLastQuest.variantes[2]; useSprite = spritesData[2]; }

        if (choiceManager.stat1 >= 3 && choiceManager.stat2 >= 3 && choiceManager.stat3 < 3)
        { textBox.text = TheLastQuest.variantes[3]; useSprite = spritesData[3]; }

        if (choiceManager.stat1 >= 3 && choiceManager.stat2 < 3 && choiceManager.stat3 >= 3)
        { textBox.text = TheLastQuest.variantes[4]; useSprite = spritesData[4]; }

        if (choiceManager.stat1 < 3 && choiceManager.stat2 >= 3 && choiceManager.stat3 >= 3)
        { textBox.text = TheLastQuest.variantes[5]; useSprite = spritesData[5]; }

        if (choiceManager.stat1 >= 3 && choiceManager.stat2 >= 3 && choiceManager.stat3 >= 3)
        { textBox.text = TheLastQuest.variantes[6]; useSprite = spritesData[6]; }

        if (choiceManager.stat1 < 3 && choiceManager.stat2 < 3 && choiceManager.stat3 < 3)
        { textBox.text = TheLastQuest.variantes[7]; useSprite = spritesData[7]; }

    }
}
