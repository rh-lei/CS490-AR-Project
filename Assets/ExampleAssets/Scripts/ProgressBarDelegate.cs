using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProgressBarDelegate : MonoBehaviour, IDragHandler
{
    public Slider progressBar;
    public VideoPlayer videoPlayer;
    
    public void OnDrag(PointerEventData eventData)
    {
        videoPlayer.time = (double) progressBar.value;
    }
}
