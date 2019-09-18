using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContentDisplay : MonoBehaviour
{
    [SerializeField] private Content content;
    [SerializeField] private Text name;
    [SerializeField] private Text description;
    [SerializeField] private Image Image;
    private int pictureNumber;
    void Start()
    {
        pictureNumber = 0;
        //name.text = content.name;
        //description.text = "Välj " + content.Description + " kapitel";
        Image.sprite = content.Image[pictureNumber];
    }
    public void nextButton()
    {
        pictureNumber++;
        if (pictureNumber < content.Image.Length)
        {
            Image.sprite = content.Image[pictureNumber];
        }
    }
    public void previousButton()
    {
        pictureNumber--;
    }
   
}
