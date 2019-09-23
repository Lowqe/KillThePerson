using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Question")]
public class Question : ScriptableObject
{
    [SerializeField] private string namn;
    [SerializeField] private string fråga;
    [SerializeField] private string svar1;
    [SerializeField] private string svar2;
    [SerializeField] private string svar3;

    public string Svar3 { get => svar3; set => svar3 = value; }
    public string Svar2 { get => svar2; set => svar2 = value; }
    public string Svar1 { get => svar1; set => svar1 = value; }
    public string Fråga { get => fråga; set => fråga = value; }
}
