using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChapterDisplay : MonoBehaviour
{
    [SerializeField]private Chapter chapter;
    [SerializeField] private Text name;
    [SerializeField] private Text description;
    [SerializeField] private Image Image;
    void Start()
    {
        //name.text = chapter.name;
        //description.text = "Välj " + chapter.Description + " kapitel";
        //Image.sprite = chapter.Image;
        Manager.Listan.Add(gameObject);
    }

   
}
