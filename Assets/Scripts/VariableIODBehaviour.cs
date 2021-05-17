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
        GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().setIODDistance(iod);
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
            iod += 0.001f * OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
            if (iod < -0.1f)
            {
                iod = -0.1f;
            }
            else if (iod > 0.3f)
            {
                iod = 0.3f;
            }
        }
        GameObject.Find("OVRCameraRig").GetComponent<P2Utils>().setIODDistance(iod);
    }
}
