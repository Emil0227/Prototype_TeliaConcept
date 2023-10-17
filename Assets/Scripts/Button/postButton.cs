using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class postButton : MonoBehaviour
{
    public void OnPointerClick()
    {
        if(!GameManager.isPostGuideCompleted)
        {
            GameManager.isPostGuideCompleted = true;
        }  
    }
}
