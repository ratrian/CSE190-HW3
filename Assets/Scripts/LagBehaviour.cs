using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.XR;

public class LagBehaviour : MonoBehaviour
{
    int numFramesTrackingLag, numFramesRenderingDelay, i;
    List<Vector3> leftEyePos = new List<Vector3>();
    List<Vector3> rightEyePos = new List<Vector3>();
    List<Quaternion> leftEyeRot = new List<Quaternion>();
    List<Quaternion> rightEyeRot = new List<Quaternion>();
    List<Vector3> controllerPos = new List<Vector3>();
    List<Quaternion> controllerRot = new List<Quaternion>();

    // Start is called before the first frame update
    void Start()
    {
        numFramesTrackingLag = 0;
        numFramesRenderingDelay = 0;
        i = -1;
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject.Find("lparent").transform.position = InputTracking.GetLocalPosition(XRNode.LeftEye);
        GameObject.Find("rparent").transform.position = InputTracking.GetLocalPosition(XRNode.RightEye);
        GameObject.Find("lparent").transform.rotation = InputTracking.GetLocalRotation(XRNode.LeftEye);
        GameObject.Find("rparent").transform.rotation = InputTracking.GetLocalRotation(XRNode.RightEye);
        GameObject.Find("controller_l").transform.position = InputTracking.GetLocalPosition(XRNode.LeftHand);
        GameObject.Find("controller_l").transform.rotation = InputTracking.GetLocalRotation(XRNode.LeftHand);*/

        // Tracking Lag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (numFramesTrackingLag > 0)
            {
                numFramesTrackingLag--;
                i = -1;
                leftEyePos.Clear();
                rightEyePos.Clear();
                leftEyeRot.Clear();
                rightEyeRot.Clear();
                controllerPos.Clear();
                controllerRot.Clear();
            }
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            numFramesTrackingLag++;
            i = -1;
            leftEyePos.Clear();
            rightEyePos.Clear();
            leftEyeRot.Clear();
            rightEyeRot.Clear();
            controllerPos.Clear();
            controllerRot.Clear();
        }
        GameObject.Find("TrackingLag").GetComponent<UnityEngine.UI.Text>().text = "Tracking Lag:\n" + numFramesTrackingLag.ToString() + " frames";
        if (i < numFramesTrackingLag - 1)
        {
            i++;
            leftEyePos.Add(InputTracking.GetLocalPosition(XRNode.LeftEye));
            rightEyePos.Add(InputTracking.GetLocalPosition(XRNode.RightEye));
            leftEyeRot.Add(InputTracking.GetLocalRotation(XRNode.LeftEye));
            rightEyeRot.Add(InputTracking.GetLocalRotation(XRNode.RightEye));
            controllerPos.Add(InputTracking.GetLocalPosition(XRNode.LeftHand));
            controllerRot.Add(InputTracking.GetLocalRotation(XRNode.LeftHand));
        }
        else if ((i != -1) && (i == numFramesTrackingLag - 1))
        {
            leftEyePos.Add(InputTracking.GetLocalPosition(XRNode.LeftEye));
            rightEyePos.Add(InputTracking.GetLocalPosition(XRNode.RightEye));
            leftEyeRot.Add(InputTracking.GetLocalRotation(XRNode.LeftEye));
            rightEyeRot.Add(InputTracking.GetLocalRotation(XRNode.RightEye));
            controllerPos.Add(InputTracking.GetLocalPosition(XRNode.LeftHand));
            controllerRot.Add(InputTracking.GetLocalRotation(XRNode.LeftHand));

            GameObject.Find("lparent").transform.position = new Vector3(leftEyePos[0].x, leftEyePos[0].y + 0.675f, leftEyePos[0].z);
            GameObject.Find("rparent").transform.position = new Vector3(rightEyePos[0].x, rightEyePos[0].y + 0.675f, rightEyePos[0].z);
            GameObject.Find("lparent").transform.rotation = leftEyeRot[0];
            GameObject.Find("rparent").transform.rotation = rightEyeRot[0];
            GameObject.Find("controller_l").transform.position = controllerPos[0];
            GameObject.Find("controller_l").transform.rotation = controllerRot[0];

            leftEyePos.RemoveAt(0);
            rightEyePos.RemoveAt(0);
            leftEyeRot.RemoveAt(0);
            rightEyeRot.RemoveAt(0);
            controllerPos.RemoveAt(0);
            controllerRot.RemoveAt(0);
        }

        // Rendering Lag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            if (numFramesRenderingDelay > 0)
            {
                numFramesRenderingDelay--;
            }
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            if (numFramesRenderingDelay < 10)
            {
                numFramesRenderingDelay++;
            }
        }
        GameObject.Find("RenderingDelay").GetComponent<UnityEngine.UI.Text>().text = "Rendering Delay:\n" + numFramesRenderingDelay.ToString() + " frames";
        Thread.Sleep(1000 * numFramesRenderingDelay / 90);
    }
}
