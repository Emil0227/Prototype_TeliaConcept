using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class helloButton : MonoBehaviour
{
    public GameObject maskRespondChoices;
    public GameObject respondChoices;
    public GameObject respondChoicesConversation;

    public GameObject chatBoxUser_Hello;

    public void OnPointerClick()
    {
        chatBoxUser_Hello.SetActive(true);
        maskRespondChoices.SetActive(false);
        respondChoices.SetActive(false);
        respondChoicesConversation.SetActive(false);
    }
}
