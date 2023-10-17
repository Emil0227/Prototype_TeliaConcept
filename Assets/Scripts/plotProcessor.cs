using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plotProcessor : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Click to enter next senario
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isLeavingScene", true);
            StartCoroutine(waitFadeOut(1.5f)); 
        }
    }

    IEnumerator waitFadeOut(float x)
    {
        yield return waitForSeconds(x);
        SceneManager.LoadScene("UsernameInput");
    }

    IEnumerator waitForSeconds(float time)
    {
        for (float t = 0.0f; t < time; t += Time.deltaTime)
        {
            yield return 0;
        }
    }
}
