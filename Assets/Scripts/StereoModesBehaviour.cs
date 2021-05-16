using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoModesBehaviour : MonoBehaviour
{
    P2Utils.RenderingMode renderingMode;

    // Start is called before the first frame update
    void Start()
    {
        renderingMode = P2Utils.RenderingMode.Stereo;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (renderingMode == P2Utils.RenderingMode.Stereo)
            {
                renderingMode = P2Utils.RenderingMode.Mono;
                GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().changeRenderingMode(renderingMode);
            }
            else if (renderingMode == P2Utils.RenderingMode.Mono)
            {
                renderingMode = P2Utils.RenderingMode.LeftOnly;
                GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().changeRenderingMode(renderingMode);
            }
            else if (renderingMode == P2Utils.RenderingMode.LeftOnly)
            {
                renderingMode = P2Utils.RenderingMode.RightOnly;
                GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().changeRenderingMode(renderingMode);
            }
            else if (renderingMode == P2Utils.RenderingMode.RightOnly)
            {
                renderingMode = P2Utils.RenderingMode.Stereo;
                /*Camera temp = GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().rightEye;
                GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().rightEye = GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().leftEye;
                GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().leftEye = temp;*/
                GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().changeRenderingMode(renderingMode);
            }
        }
    }
}
