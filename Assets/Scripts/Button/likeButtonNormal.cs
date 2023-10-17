using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class likeButtonNormal : MonoBehaviour
{
    public Sprite like_normal;
    public Sprite like_liked;

    bool isLiked = false;
    Button button1;
    public void OnPointerClick()
    {
        if (!isLiked)
        {
            button1 = gameObject.GetComponent<Button>();
            button1.image.sprite = like_liked;
            isLiked = true;
        }
        else
        {
            button1 = gameObject.GetComponent<Button>();
            button1.image.sprite = like_normal;
            isLiked = false;
        }
    }
}
