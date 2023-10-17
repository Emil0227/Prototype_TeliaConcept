using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guideStart : MonoBehaviour
{
    public GameObject guide;
    public GameObject maskLike;
    public GameObject maskComment;
    public GameObject maskPost;
    public GameObject maskChatpage;
    public GameObject pressLikeConversation;
    public GameObject pressCommentConversation;
    public GameObject pressPostConversation;
    public GameObject pressChatpageConversation;
    Animator anim;
    void Start()
    {
        GameManager.isScrollAllowed = false;
        anim = guide.gameObject.GetComponent<Animator>();
        GameManager.isLikeGuideCompleted = false;
        GameManager.isCommentGuideCompleted = false;
        GameManager.isPostGuideCompleted = false;
        GameManager.isChatpageGuideCompleted = false;
        maskLike.SetActive(true);
        anim.SetInteger("state", 1);
        StartCoroutine(waitForLikeGuide(1f));
    }

    void Update()
    {
        //player click "like" button according to guidance
        if (GameManager.isLikeGuideCompleted && !GameManager.isCommentGuideCompleted && !GameManager.isPostGuideCompleted)
        {
            maskLike.SetActive(false);
            maskComment.SetActive(true);
            pressLikeConversation.SetActive(false);
            pressCommentConversation.SetActive(true);
            anim.SetInteger("state", 2);

        }
        //player click "comment" button according to guidance
        else if (GameManager.isLikeGuideCompleted && GameManager.isCommentGuideCompleted && !GameManager.isPostGuideCompleted)
        {
            maskComment.SetActive(false);
            maskPost.SetActive(true);
            pressCommentConversation.SetActive(false);
            pressPostConversation.SetActive(true);
            anim.SetInteger("state", 3);
        }
        //player click "post" button according to guidance
        else if (GameManager.isPostGuideCompleted && !GameManager.isChatpageGuideCompleted)
        {
            maskPost.SetActive(false);
            maskChatpage.SetActive(true);
            pressPostConversation.SetActive(false);
            pressChatpageConversation.SetActive(true);
            anim.SetInteger("state", 4);
        }

    }

    IEnumerator waitForLikeGuide(float x)
    {
        yield return waitForSeconds(x);
        pressLikeConversation.SetActive(true);
    }

    IEnumerator waitForSeconds(float time)
    {
        for (float t = 0.0f; t < time; t += Time.deltaTime)
        {
            yield return 0;
        }
    }
}
