using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class IntroVideoController : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    public Button skipButton;
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        skipButton.onClick.AddListener(SkipVideo);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnVideoEnd(UnityEngine.Video.VideoPlayer vp)
    {
        // Charger la sc�ne du menu principal
        SceneManager.LoadScene("Menu");
    }

    public void SkipVideo()
    {
        videoPlayer.Stop();
        SceneManager.LoadScene("Menu");
    }
}
