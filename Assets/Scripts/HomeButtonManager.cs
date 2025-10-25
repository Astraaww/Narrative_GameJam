using UnityEngine;
using UnityEngine.EventSystems;
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
