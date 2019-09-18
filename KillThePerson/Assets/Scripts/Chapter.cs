using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Chapter", menuName = "Chapter")]
public class Chapter : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private string description;
    [SerializeField] private Sprite image;
    public string Description { private set => description = value; get => description; }
    public Sprite Image { private set => image = value; get => image; }
    public string Name { get => name; private set => name = value; }
}
