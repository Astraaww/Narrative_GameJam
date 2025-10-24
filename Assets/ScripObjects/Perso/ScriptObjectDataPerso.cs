using UnityEngine;

[CreateAssetMenu(fileName = "DataPerso", menuName = "Data Personnages")]
public class DataPerso : ScriptableObject
{
    public string anwserTheQuestion;
    public Question[] questions;
    public float textSpeed;
}