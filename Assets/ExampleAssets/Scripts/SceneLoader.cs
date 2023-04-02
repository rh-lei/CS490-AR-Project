using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // webview links
    public static string webviewLink;
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
        if (buttonName == "AR")
        {
            SceneManager.LoadScene("UIButton");
        } 
        else if (buttonName == "Home")
        {
            SceneManager.LoadScene("HomeMenu");
        } 
        else if (buttonName == "Video")
        {
            SceneManager.LoadScene("VideoDisplay");
        }
        else
        {
            openWebviewLink(buttonName);
            SceneManager.LoadScene("WebView");
        }
    }

    public void openWebviewLink(string button)
    {
        if (button == "Video")
        {
            webviewLink = "https://www.figma.com/proto/PZS06yyLrPuB9i4pwD2RgO/HMI-Prototype?node-id=1057%3A63&scaling=min-zoom&page-id=1057%3A48&starting-point-node-id=1057%3A49";
        } 
        else 
        {
            webviewLink = "https://www.figma.com/proto/PZS06yyLrPuB9i4pwD2RgO/HMI-Prototype?node-id=1438%3A75&scaling=min-zoom&page-id=1057%3A48&starting-point-node-id=1057%3A49";
        }
        
    }
}
