using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement; 

public class HomeButtonManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject text;
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.SetActive(true); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
       text.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
