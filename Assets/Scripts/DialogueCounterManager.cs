using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DialogueCounterManager : MonoBehaviour
{

    public GameObject dialoguePanel;
    public TextMeshProUGUI counter; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialoguePanel.activeSelf)
        {
            counter.rectTransform.anchoredPosition = new Vector3(-778f, 0f, 0f);
        }
        else
        {
            counter.rectTransform.anchoredPosition = new Vector3(-809f, 450f, 0f);
        }
    }
}
