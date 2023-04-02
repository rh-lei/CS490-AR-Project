using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoPlayerManager : MonoBehaviour
{
    public Sprite playButton;
    public Sprite pauseButton;
    public Button playPauseButton;
    public Text CurTime;
    public Text FullTime;

    public Slider progressBar;
    public VideoPlayer videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        reset();
    }

    // Update is called once per frame
    void Update()
    {
        progressBar.value = (float) videoPlayer.time;
        if (!videoPlayer.isPlaying && progressBar.value > progressBar.maxValue -1)
        {
            playPauseButton.GetComponent<Image>().sprite = playButton;
        }
        CurTime.text = doubleToTime((double) videoPlayer.time);
    }

    public void playPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playPauseButton.GetComponent<Image>().sprite = playButton;
        } else
        {
            videoPlayer.Play();
            playPauseButton.GetComponent<Image>().sprite = pauseButton;
        }
    }

    public void reset()
    {
        playPauseButton.GetComponent<Image>().sprite = playButton;

        progressBar.minValue = 0;
        double fullTime = (videoPlayer.frameCount + 1) / videoPlayer.frameRate;
        progressBar.maxValue = (float) fullTime;
        FullTime.text = doubleToTime(fullTime, "full");

        progressBar.value = 0;
        CurTime.text = doubleToTime((double) progressBar.value);

        // set preview to first frame
        videoPlayer.time = 0;
        videoPlayer.Play();
        videoPlayer.Pause();
    }

    public string doubleToTime(double seconds, string type = "cur")
    {
        int minute = (int) Math.Floor(seconds / 60);
        int second = (int) Math.Floor(seconds % 60);

        if (type == "cur")
        {
            return String.Format("{0:D2}:{1:D2}", minute, second);
        } else
        {
            return String.Format(" / {0:D2}:{1:D2}", minute, second);
        }
        
    }
}
