using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picture : MonoBehaviour
{
    private bool isRight;
    private bool isAssigned;
    private bool isPressed;
    private void Start()
    {
        isPressed = false;
    }

    public bool ReturnIsAssigned()
    {
        return isAssigned;
    }
    public bool ReturnIsRight()
    {
        return isRight;
    }
    public void Assign(bool isAssigned, bool isRight)
    {
        Debug.Log(isRight);
        this.isRight = isRight;
        this.isAssigned = isAssigned;
    }
    public void AssingedFalse()
    {
        isAssigned = false;
    }

    public void CheckPicture()
    {
        if (!isPressed)
        {
            Debug.Log(isRight);
            if (isRight)
            {
                Manager.Instance.AddMemoryScore(1);
                GetComponent<Image>().color = Color.green;
            }
            else
            {
                Manager.Instance.AddMemoryScore(-1);
                GetComponent<Image>().color = Color.red;
            }
        }
    }
}
