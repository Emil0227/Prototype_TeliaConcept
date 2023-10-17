using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenControl : MonoBehaviour
{
    bool isMouseDown = false;
    Vector3 oldMousePos = new Vector3();

    void Update()
    {
        if(GameManager.isScrollAllowed)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                isMouseDown = true;
                oldMousePos = Input.mousePosition;//mouse position on click
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                isMouseDown = false;
            }
            if (isMouseDown == true)//user wants to drag screen
            {
                Vector3 pos = Input.mousePosition - oldMousePos;
                float offsetY = 0.0f;
                if ((pos.y < 0 && transform.position.y > -2.383f) || (pos.y > 0 && transform.position.y < 2.37f))//screen can be dragged
                {
                    offsetY = pos.y * 0.005f;
                }
                transform.position = new Vector3(0, transform.position.y + offsetY, 0);
                oldMousePos = Input.mousePosition;//take current mouse position, prepare for next drag
            }
        }      
    }
}
