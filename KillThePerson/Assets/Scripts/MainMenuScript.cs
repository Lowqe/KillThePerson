using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void ChapterScene()
    {
        SceneManager.LoadScene("ChapterScene");
    }

    public void MainMenuScene()
    {
        Manager.ChapterList.Clear();
        Manager.AnswerList.Clear();
        Manager.MemoryList.Clear();
        SceneManager.LoadScene("Menu");
    }
}
