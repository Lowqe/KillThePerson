using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private int score;

    public static List<GameObject> ChapterList { private set; get; }
    public static List<GameObject> AnswerList { get; private set; }

    public static Manager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        if(ChapterList == null)
        {
            ChapterList = new List<GameObject>();
        }
        if(AnswerList == null)
        {
            AnswerList = new List<GameObject>();
        }
        score = 0;
    }
    public void AddScore()
    {
        score++;
    }
    public void RemoveScore()
    {
        score = 0;
    }
    public int GetScore()
    {
        return score;
    }
}
