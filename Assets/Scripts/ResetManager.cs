using UnityEngine;
using UnityEngine.UI;

public class ResetManager : MonoBehaviour
{
    ChoiceManager choiceManager;
    DialogManager dialogManager;

    void Start()
    {
        choiceManager = GetComponent<ChoiceManager>();
        dialogManager = GetComponent<DialogManager>();
    }

    public void ResetQuestion()
    {
        foreach (GameObject go in choiceManager.boutonsQuestion) 
        { 
            go.GetComponent<Button>().enabled = true; 
            go.SetActive(true);
        }

    }
}
