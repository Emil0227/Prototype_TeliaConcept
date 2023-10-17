using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class usernameInput : MonoBehaviour
{
    public InputField inputField;
    void Start()
    {
        inputField.onValueChanged.AddListener(OnInputValueChanged);
    }

    private void OnInputValueChanged (string value)
    {
        print(value);
    }
}
