using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string buttonName)
    {
        if (buttonName == "Tutorial")
        {
            SceneManager.LoadScene("SteeringWheel");
        } 
        else if (buttonName == "Home")
        {
            SceneManager.LoadScene("HomePage");
        } 
        else if (buttonName == "Stimulation")
        {
            SceneManager.LoadScene("RoadSign");
        }
        else
        {
            SceneManager.LoadScene("HomePage");
        }
    }
}
