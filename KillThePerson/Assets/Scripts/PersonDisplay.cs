using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PersonDisplay : MonoBehaviour
{
    [SerializeField]private Person person;
    [SerializeField] private Text name;
    [SerializeField] private Text description;
    [SerializeField] private Image Image;
    void Start()
    {
        name.text = person.name;
        description.text = person.Description;
        Image.sprite = person.Image;
    }

   
}
