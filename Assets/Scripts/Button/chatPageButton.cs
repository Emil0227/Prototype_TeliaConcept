using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chatPageButton : MonoBehaviour
{
    public void OnPointerClick()
    {
        SceneManager.LoadScene("ChatPage");
    }
}
