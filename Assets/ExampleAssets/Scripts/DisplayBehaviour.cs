using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayBehaviour : MonoBehaviour
{
    public GameObject tutorialCanvas;
    // Start is called before the first frame update
    void Start()
    {
        tutorialCanvas.SetActive(true);
    }

    public void enableTutorial() 
    {
        tutorialCanvas.SetActive(true);
    }

    public void disableTutorial() 
    {
        tutorialCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
