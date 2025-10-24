using System;
using UnityEngine;

[Serializable]
public class Question
{
    [TextArea(2, 15)]
    public string[] variantes = new string[8];
    public AnswerText answer;
}
