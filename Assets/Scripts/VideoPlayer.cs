using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;
using System;

public class VideoPlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    internal Action<UnityEngine.Video.VideoPlayer> loopPointReached;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnVideoEnd(UnityEngine.Video.VideoPlayer vp)
    {
        // Charger la scène du menu principal
        SceneManager.LoadScene("Menu");
    }


}
