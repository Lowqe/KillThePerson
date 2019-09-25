using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    private bool right;
    [SerializeField] private Text answerField;
    [SerializeField] private Text text;
    private void Start()
    {
        Manager.AnswerList.Add(gameObject);
    }
    public void SetQuestion(string answer, bool right)
    {
       text.text = answer;
        this.right = right;
    }
    public void CheckAnswer()
    {
        foreach(GameObject go in Manager.AnswerList)
        {
            go.SetActive(false);
        }
        if (right)
        {
            answerField.text = "Rätt";
            Manager.Instance.AddQuizScore();
        }
        else
        {
            answerField.text = "Fel";
        }
    }
}
