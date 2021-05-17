using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tracking Lag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {

        }

        // Rendering Lag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {

        }
    }
}
