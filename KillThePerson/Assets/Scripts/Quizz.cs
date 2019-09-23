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
    private int questionNumber;

    private void Start()
    {
        fråga.text = frågor[0].Fråga;
        svar1.text = frågor[0].Svar1;
        svar2.text = frågor[0].Svar2;
        svar3.text = frågor[0].Svar3;
    }
    public void SetQuestion()
    {
        if(questionNumber < frågor.Count-1)
        {
            questionNumber++;
            fråga.text = frågor[questionNumber].Fråga;
            svar1.text = frågor[questionNumber].Svar1;
            svar2.text = frågor[questionNumber].Svar2;
            svar3.text = frågor[questionNumber].Svar3;
        }
    }
}
