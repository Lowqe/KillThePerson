using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuiz : MonoBehaviour
{
    [SerializeField] private GameObject quiz;
   
    public void Quiz()
    {
        quiz.SetActive(true);
        quiz.GetComponent<Quiz>().ZeroTheQuiz();
    }
}
