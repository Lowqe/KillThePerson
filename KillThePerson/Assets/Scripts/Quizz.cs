using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizz : MonoBehaviour
{
    [SerializeField] private GameObject svar1;
    [SerializeField] private GameObject svar2;
    [SerializeField] private GameObject svar3;
    [SerializeField] private Text fråga;
    [SerializeField] private Text svar;
    [SerializeField] private List<Question> frågor;
    private int questionNumber;

    private void Start()
    {
        questionNumber = 0;
        svar.text = "";
        SetQuestion();
    }
    public void SetQuestion()
    {
        fråga.text = frågor[questionNumber].Fråga;
        string fråga1 = frågor[questionNumber].Svar1;
        string fråga2 = frågor[questionNumber].Svar2;
        string fråga3 = frågor[questionNumber].Svar3;
      
            float number = Random.Range(1, 3.99f);
            int round = (int)number;
            switch (round)
            {
                case 1:
                    svar1.GetComponent<AnswerButton>().SetQuestion(fråga1, true);
                    svar2.GetComponent<AnswerButton>().SetQuestion(fråga2, false);
                    svar3.GetComponent<AnswerButton>().SetQuestion(fråga3, false);
                    break;
                case 2:
                    svar1.GetComponent<AnswerButton>().SetQuestion(fråga2, false);
                    svar2.GetComponent<AnswerButton>().SetQuestion(fråga1, true);
                    svar3.GetComponent<AnswerButton>().SetQuestion(fråga3, false);
                    break;
                case 3:
                    svar1.GetComponent<AnswerButton>().SetQuestion(fråga3, false);
                    svar2.GetComponent<AnswerButton>().SetQuestion(fråga2, false);
                    svar3.GetComponent<AnswerButton>().SetQuestion(fråga1, true);
                    break;
            }
        
    }
    public void NextQuestion()
    {
        if (questionNumber < frågor.Count -1)
        {
            questionNumber++;
            SetQuestion();
        }
        else
        {
            svar1.SetActive(false);
            svar2.SetActive(false);
            svar3.SetActive(false);
            fråga.text = "";
            if(Manager.Instance.GetScore() == 0)
            {
                svar.text = "Inga rätt svar";
            }
            else
            {
                svar.text = "Rätt svar " + Manager.Instance.GetScore();
            }
        }
         
    }
    public void SetSvar()
    {

    }
}
