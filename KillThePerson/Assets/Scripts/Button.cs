using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject content;
    public void HideContent()
    {
        foreach (GameObject go in Manager.Listan)
        {
            go.SetActive(false);
        }
        content.SetActive(true);
    }
    public void ShowContent()
    {
        content.SetActive(false);
        foreach(GameObject go in Manager.Listan)
        {
            go.SetActive(true);
        }
    }
}
