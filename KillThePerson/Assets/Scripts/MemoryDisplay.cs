using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MemoryDisplay : MonoBehaviour
{
    [SerializeField] private Chapter[] chapters;
    [SerializeField] private Content[] contents;
    [SerializeField] private Image chapterImage;
    [SerializeField] private GameObject[] buttons;
    [SerializeField] private GameObject startMemory;
    [SerializeField] private Text antalRätt;
    [SerializeField] private Text kapitelText;
    private int chapterNumber;
    private int imageNumber;
    private int maxPictures;
    private List<int> usedNumbers;

    // Start is called before the first frame update
    void Start()
    {
        maxPictures = 9;
    }

    public void StartMemory()
    {
        startMemory.SetActive(true);
        foreach (GameObject go in Manager.MemoryList)
        {
            go.SetActive(true);
        }
        chapterNumber = 0;
        SetMemory();
        antalRätt.text = "";
    }
    public void ExitMemory()
    {
        startMemory.SetActive(false);
        Manager.Instance.RemoveMemoryScore();
    }

    public void NextMemory()
    {
        if(chapterNumber < chapters.Length - 1)
        {
            imageNumber = 0;
            chapterNumber++;
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Picture>().AssingedFalse();
            }
            foreach (GameObject go in Manager.MemoryList)
            {
                go.GetComponent<Image>().color = Color.white;
            }
            SetMemory();
        }
        else
        {
            foreach(GameObject go in Manager.MemoryList)
            {
                go.SetActive(false);
            }
            antalRätt.text = "Antal rätt: " + Manager.Instance.GetMemoryScore();
            kapitelText.text = "";
        }
    }

    public void SetMemory()
    {
        usedNumbers = new List<int>();
        kapitelText.text = chapters[chapterNumber].Name;
        chapterImage.sprite = chapters[chapterNumber].Image;
        Sprite[] firstSet = contents[chapterNumber].Image;
        SetPictures(true, firstSet);
        while(imageNumber < maxPictures)
        {
            int  random = RandomNumber();
            usedNumbers.Add(random);
            SetPictures(false, contents[random].Image);
        }
    }

    private void SetPictures(bool isRight, Sprite[] set)
    {
        for (int i = 0; i < set.Length; i++)
        {
            imageNumber++;
            if (imageNumber <= maxPictures)
            {
                GameObject assignObject = buttons[Assigned()];
                assignObject.GetComponent<Image>().sprite = set[i];
                assignObject.GetComponent<Picture>().Assign(true, isRight);
            }
            else{
                return;
            }
        }
    }
    private int Assigned()
    {
        int random = 0;
        do
        {
            random = (int)Random.Range(0, buttons.Length - 0.1f);
        }
        while (buttons[random].GetComponent<Picture>().ReturnIsAssigned());
        return random;
    }

    private int RandomNumber()
    {
        int random = 0;
        do
        {
            random = (int)Random.Range(1, (chapters.Length - 0.1f));
        }
        while (CheckNumbers(random) || random == chapterNumber);
        return random;
    }
    private bool CheckNumbers(int number)
    {
        for(int i =0; i < usedNumbers.Count; i++)
        {

            if(number == usedNumbers[i])
            {
                return true;
            }
        }
        return false;
    }
}
