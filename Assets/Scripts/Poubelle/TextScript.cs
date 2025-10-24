using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TMP_Text))]
public class TextScript : MonoBehaviour, IPointerClickHandler //, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        var text = GetComponent<TextMeshProUGUI>();
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, null);
            if (linkIndex > -1)
            {
                Debug.Log(text.textInfo.linkInfo[linkIndex].GetLinkID());
                text.textInfo.linkInfo[2].GetLinkText();
            }
        }
    }

    private void Update()
    {
        var text = GetComponent<TextMeshProUGUI>();
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, null);
        if (linkIndex > -1)
        {
            Debug.Log("pingouin");
        }
    }

    // ça marche que quand on sort de la zone de texte pas de lien
    /*
    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
    */
}
