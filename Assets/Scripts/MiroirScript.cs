using UnityEngine;

public class MiroirScript : MonoBehaviour
{
    DialogueCounterManager manager;

    void Start()
    {
        manager = FindAnyObjectByType<DialogueCounterManager>();
    }

    public void OnClick()
    {
        if (CanContinue()) { } // la fin et nsm je veux pas faire ça mtn
        else { } //tu te fais rembarer

    }

    bool CanContinue()
    {
        if (manager.creditDialogue == 0)
            return true;

        return false;
    }

}
