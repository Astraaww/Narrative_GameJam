using UnityEngine;

public class TheQuestionButtonScript : MonoBehaviour
{
    [SerializeField] Question data;

    ChoiceManager choiceManager;

    void Start()
    {
        choiceManager = FindAnyObjectByType<ChoiceManager>();
    }





}
