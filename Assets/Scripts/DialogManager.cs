using System.Collections;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public AnswerText texte;
    public float textSpeed;
    public bool isActivated;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        isActivated = false;
    }

    public void SetSpeed(float speed)
    { 
        textSpeed = speed; 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isActivated)
            {
                if (textComponent.text == texte.lines[index])
                {
                    Nextline();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = texte.lines[index];
                }
            }           
        }
    }

    public void StartDialog(AnswerText reftext)
    {
        texte = reftext;
        isActivated = true;
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in texte.lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void ResetBox()
    { textComponent.text = string.Empty; }

    void Nextline()
    {
        if (index < texte.lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            textComponent.text = string.Empty;
            isActivated = false;
        }
    }
}
