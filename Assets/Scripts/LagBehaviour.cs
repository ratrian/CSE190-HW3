using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagBehaviour : MonoBehaviour
{
    int numFramesTrackingLag, numFramesRenderingDelay;

    // Start is called before the first frame update
    void Start()
    {
        numFramesTrackingLag = 0;
        numFramesRenderingDelay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Tracking Lag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (numFramesTrackingLag > 0)
            {
                numFramesTrackingLag--;
            }
            //
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            numFramesTrackingLag++;
            //
        }
        GameObject.Find("TrackingLag").GetComponent<UnityEngine.UI.Text>().text = "Tracking Lag:\n" + numFramesTrackingLag.ToString() + " frames";

        // Rendering Lag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            if (numFramesRenderingDelay > 0)
            {
                numFramesRenderingDelay--;
            }
            //
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            numFramesRenderingDelay++;
            //
        }
        GameObject.Find("RenderingDelay").GetComponent<UnityEngine.UI.Text>().text = "Rendering Delay:\n" + numFramesRenderingDelay.ToString() + " frames";
    }
}
