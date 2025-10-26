using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    bool hastimer;
    float time;

    void Update()
    {
        if (hastimer)
        {
            if (time < 3) { time += Time.deltaTime; }
            else { SceneManager.LoadScene(1); }
        }
    }

    private void Start()
    {
        hastimer = false;
    }



    public void PlayGame()
    {
        hastimer = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
