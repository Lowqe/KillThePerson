using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject howToPlay;
    [SerializeField] private GameObject content;
    public void HideContent()
    {
        foreach (GameObject go in Manager.ChapterList)
        {
            go.SetActive(false);
        }
        content.SetActive(true);
    }

    public void HowToPlay()
    {
        howToPlay.SetActive(true);
        content.SetActive(false);

    }
    public void CloseHowToPlay()
    {
        howToPlay.SetActive(false);
    }

    public void ShowContent()
    {
        if(name.Equals("Stop quizz"))
        {
            Debug.Log("score = 0");
            Manager.Instance.RemoveScore();
        }
        content.SetActive(false);
        foreach(GameObject go in Manager.ChapterList)
        {
            go.SetActive(true);
        }
    }
}
