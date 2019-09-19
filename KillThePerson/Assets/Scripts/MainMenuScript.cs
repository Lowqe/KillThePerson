﻿using System.Collections;
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
        Manager.Listan.Clear();
        SceneManager.LoadScene("Menu");
    }
}
