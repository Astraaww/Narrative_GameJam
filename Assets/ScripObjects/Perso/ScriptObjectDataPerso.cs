using UnityEngine;

[CreateAssetMenu(fileName = "DataPerso", menuName = "Data Personnages")]
public class DataPerso : ScriptableObject
{
    public AnswerText anwserTheQuestion;
    public Question[] questions;
    public float textSpeed;
}