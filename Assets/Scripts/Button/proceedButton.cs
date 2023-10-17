using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class proceedButton : MonoBehaviour
{
    public InputField inputField;
    public void OnPointerClick()
    {
        GameManager.username = inputField.text;
        SceneManager.LoadScene("HomePage");
    }
}
