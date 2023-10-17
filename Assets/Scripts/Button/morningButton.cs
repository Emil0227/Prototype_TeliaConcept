using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class morningButton : MonoBehaviour
{
    public GameObject maskRespondChoices;
    public GameObject respondChoices;
    public GameObject respondChoicesConversation;

    public GameObject chatBoxUser_Morning;

    public void OnPointerClick()
    {
        chatBoxUser_Morning.SetActive(true);
        maskRespondChoices.SetActive(false);
        respondChoices.SetActive(false);
        respondChoicesConversation.SetActive(false);
    }
}
