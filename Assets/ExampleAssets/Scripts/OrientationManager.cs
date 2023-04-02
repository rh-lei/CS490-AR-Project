using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OrientationManager : UIBehaviour
{
    public GameObject PortraitOverlay;
    public GameObject LandscapeOverlay;

    // Update is called once per frame
    void Update()
    {
        // landscape view
        if ( (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight) && PortraitOverlay.activeSelf )
        {
            LandscapeOverlay.SetActive(true);
            PortraitOverlay.SetActive(false);
        }
        // portrait view
        else if ( (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown) && LandscapeOverlay.activeSelf )
        {
            LandscapeOverlay.SetActive(false);
            PortraitOverlay.SetActive(true);
        }
    }

    // Destroy overlays on application quit
    void OnApplicationQuit()
    {
        Destroy(PortraitOverlay);
        Destroy(LandscapeOverlay);
    }
}
