using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayBehaviour : MonoBehaviour
{
    public GameObject guideCanvas;
    // Start is called before the first frame update
    void Start()
    {
        guideCanvas.SetActive(true);
    }

    public void enableGuide() 
    {
        guideCanvas.SetActive(true);
    }

    public void disableGuide() 
    {
        guideCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

