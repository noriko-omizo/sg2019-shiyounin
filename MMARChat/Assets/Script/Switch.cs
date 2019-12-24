using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class Switch : MonoBehaviour
{
    [SerializeField] GameObject startCanvas;
    [SerializeField] GameObject chatCanvas;

    [SerializeField] GameObject dengenPanel;
    [SerializeField] GameObject videoCanvas;

    [SerializeField] Player player;

    // [SerializeField] Image dengenButton;


    // private Animator animator;

    public VideoPlayer videoPlayer;

    bool push = false;

    public bool videoplay;
    bool end = true;


    // Start is called before the first frame update
    void Awake()
    {
        startCanvas.SetActive(true);
    }
    void Start()
    {
        // animator = transform.gameObject.GetComponent<Animator>();
        // startCanvas.SetActive(true);
        videoCanvas.SetActive(true);
        dengenPanel.SetActive(true);
    }

    public void PushDown()
    {
        push = true;
        dengenPanel.SetActive(false);
    }

    public void PushUp()
    {
        push = false;
    }


    void Update()
    {

        if (push && end)
        {
            // animator.SetBool("loadmove", !animator.GetBool("loadmove"));
            // animator.SetFloat("MovingSpeed", 0.1f);
            videoPlayer.Play();
            videoplay = true;
        }

        if (push == false && end)
        {
            // animator.SetFloat("stopmotion", 0.0f);
            videoPlayer.Pause();
            videoplay = false;
        }


        // if (end == false)
        // {
        //     // animator.SetBool("end", !animator.GetBool("end"));
        //     startCanvas.SetActive(false);
        //     chatCanvas.SetActive(true);
        // }
        if (videoplay)
        {
            Debug.Log(videoPlayer.frame + ", " + videoPlayer.frameCount);
        }
        if (videoPlayer.frame != 0 && ((int)videoPlayer.frame == (int)videoPlayer.frameCount - 60))
        {
            videoPlayer.Play();
            end = false;

        }

        if (videoPlayer.frame != 0 && ((int)videoPlayer.frame == (int)videoPlayer.frameCount - 1))
        {
            Debug.Log("end");
            startCanvas.SetActive(false);
            videoCanvas.SetActive(false);
            chatCanvas.SetActive(true);
            videoPlayer.Stop();
            end = false;
            player.entrance = true;

        }
    }


    // public void OnClick()
    // {
    //     dengenPanel.SetActive(false);
    // }

}
