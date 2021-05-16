using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrackingBehaviour : MonoBehaviour
{
    public enum TrackingMode { Regular, PositionOnly, RotationOnly, NoTracking };
    TrackingMode trackingMode;

    // Start is called before the first frame update
    void Start()
    {
        trackingMode = TrackingMode.Regular;
        GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().usePositionTracking = true;
        GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().useRotationTracking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (trackingMode == TrackingMode.Regular)
            {
                trackingMode = TrackingMode.PositionOnly;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().usePositionTracking = false;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().useRotationTracking = true;
            }
            else if (trackingMode == TrackingMode.PositionOnly)
            {
                trackingMode = TrackingMode.RotationOnly;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().usePositionTracking = true;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().useRotationTracking = false;
            }
            else if (trackingMode == TrackingMode.RotationOnly)
            {
                trackingMode = TrackingMode.NoTracking;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().usePositionTracking = false;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().useRotationTracking = false;
            }
            else if (trackingMode == TrackingMode.NoTracking)
            {
                trackingMode = TrackingMode.Regular;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().usePositionTracking = true;
                GameObject.Find("OVRCameraRig").GetComponent<OVRManager>().useRotationTracking = true;
            }
        }
    }
}
