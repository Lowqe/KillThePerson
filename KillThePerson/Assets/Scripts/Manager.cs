using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static List<GameObject> Listan { private set; get; }
    private static Manager manager;
    private void Awake()
    {
        if(manager == null)
        {
            manager = this;
        }
        if(Listan == null)
        {
            Listan = new List<GameObject>();
        }
    }
}
