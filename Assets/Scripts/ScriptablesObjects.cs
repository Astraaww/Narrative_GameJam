using UnityEngine;

[CreateAssetMenu(fileName = "Answer", menuName = "Answer File")]
public class AnswerText : ScriptableObject
{
    [TextArea(3, 15)]
    public string[] lines;
}
