using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Content", menuName = "Content")]
public class Content : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private Sprite[] image;
    public string Name { get => name; private set => name = value; }
    public Sprite[] Image { get => image; private set => image = value; }
}
