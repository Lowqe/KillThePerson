using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private int quizScore;
    private int memeoryScore;
    public static List<GameObject> ChapterList { private set; get; }
    public static List<GameObject> AnswerList { get; private set; }

    public static List<GameObject> MemoryList { get; private set; }

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
        if(MemoryList == null)
        {
            MemoryList = new List<GameObject>();
        }
            quizScore = 0;
    }
    public void AddQuizScore()
    {
        quizScore++;
    }
    public void RemoveQuizScore()
    {
        quizScore = 0;
    }
    public int GetQuizScore()
    {
        return quizScore;
    }
    public int GetMemoryScore()
    {
        Debug.Log("MemoryScore: " + memeoryScore);
        return memeoryScore;
    }
    public void RemoveMemoryScore()
    {
        memeoryScore = 0;
    }
    public void AddMemoryScore(int addScore)
    {
        Debug.Log("Added score: " + addScore);
        memeoryScore += addScore;
    }
}
