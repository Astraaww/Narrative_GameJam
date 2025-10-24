using UnityEngine;


public class DescriptionScript : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Update()
    {
        if (panel.activeInHierarchy)
        {
            panel.GetComponent<RectTransform>().position = Input.mousePosition;
        }
    }
}
