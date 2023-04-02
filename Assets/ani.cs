using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ani : MonoBehaviour
{
    public GameObject SampleButton;
    public Animator CubeAnimation;

    // Start is called before the first frame update
    void Start()
    {
        SampleButton = GameObject.Find("SampleButton");
        SampleButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        SampleButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        CubeAnimation.GetComponent<Animator>();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        CubeAnimation.Play("CubeAnimation");
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        CubeAnimation.Play("none");
        Debug.Log("BTN Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
