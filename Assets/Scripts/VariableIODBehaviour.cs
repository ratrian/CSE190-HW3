using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableIODBehaviour : MonoBehaviour
{
    float iod;

    // Start is called before the first frame update
    void Start()
    {
        iod = 0.065f;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            iod = 0.065f;
        }
        else
        {
            iod += OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
        }
        GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().setIODDistance(iod);
    }
}
