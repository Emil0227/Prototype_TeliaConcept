using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guideChat : MonoBehaviour
{
    public GameObject guide;
    public GameObject maskChatGuide;
    public GameObject maskRespondChoices;
    public GameObject startChatConversation;
    public GameObject respondChoicesConversation;

    public GameObject chatBoxRobert;
    public GameObject respondChoices;

    Animator anim;
    void Start()
    {
        anim = guide.gameObject.GetComponent<Animator>();
        GameManager.isStartChatGuideShown = false;
        GameManager.isStartChatGuideCompleted = false;
        maskChatGuide.SetActive(true);
        anim.SetInteger("state", 5);
        StartCoroutine(waitForChatGuide(1f));

    }

    void Update()
    {
        //click screen to continue guide
        if (GameManager.isStartChatGuideShown && !GameManager.isStartChatGuideCompleted)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                maskChatGuide.SetActive(false);
                startChatConversation.SetActive(false);
                chatBoxRobert.SetActive(true);
                anim.SetInteger("state", 6);
                respondChoices.SetActive(true);
                maskRespondChoices.SetActive(true);
                respondChoicesConversation.SetActive(true);
                GameManager.isStartChatGuideCompleted = true;
            }
        }
    }
    IEnumerator waitForChatGuide(float x)
    {
        yield return waitForSeconds(x);
        startChatConversation.SetActive(true);
        GameManager.isStartChatGuideShown = true;
    }
    IEnumerator waitForSeconds(float time)
    {
        for (float t = 0.0f; t < time; t += Time.deltaTime)
        {
            yield return 0;
        }
    }
}
