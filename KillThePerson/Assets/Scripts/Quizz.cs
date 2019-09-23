using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizz : MonoBehaviour
{
    [SerializeField] private Text svar1;
    [SerializeField] private Text svar2;
    [SerializeField] private Text svar3;
    [SerializeField] private Text fråga;
    [SerializeField] private Text svar;
    [SerializeField] private List<Question> frågor;

    private void Start()
    {
        fråga.text = frågor[0].Fråga;
        svar1.text = frågor[0].Svar1;
        svar2.text = frågor[0].Svar2;
        svar3.text = frågor[0].Svar3;
    }
}
