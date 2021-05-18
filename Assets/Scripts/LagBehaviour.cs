using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LagBehaviour : MonoBehaviour
{
    int numFramesTrackingLag, numFramesRenderingDelay, i;
    List<Vector3> leftEyePos = new List<Vector3>();
    List<Vector3> rightEyePos = new List<Vector3>();
    List<Quaternion> leftEyeRot = new List<Quaternion>();
    List<Quaternion> rightEyeRot = new List<Quaternion>();

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
        }
        GameObject.Find("TrackingLag").GetComponent<UnityEngine.UI.Text>().text = "Tracking Lag:\n" + numFramesTrackingLag.ToString() + " frames";
        if (i < numFramesTrackingLag - 1)
        {
            i++;
            leftEyePos.Add(GameObject.Find("lparent").transform.position);
            rightEyePos.Add(GameObject.Find("rparent").transform.position);
            leftEyeRot.Add(GameObject.Find("lparent").transform.rotation);
            rightEyeRot.Add(GameObject.Find("rparent").transform.rotation);
        }
        else if ((i != -1) && (i == numFramesTrackingLag - 1))
        {
            leftEyePos.Add(GameObject.Find("lparent").transform.position);
            rightEyePos.Add(GameObject.Find("rparent").transform.position);
            leftEyeRot.Add(GameObject.Find("lparent").transform.rotation);
            rightEyeRot.Add(GameObject.Find("rparent").transform.rotation);

            /*GameObject.Find("lparent").transform.position = leftEyePos[0];
            GameObject.Find("rparent").transform.position = rightEyePos[0];
            GameObject.Find("lparent").transform.rotation = leftEyeRot[0];
            GameObject.Find("rparent").transform.rotation = rightEyeRot[0];*/

            leftEyePos.RemoveAt(0);
            rightEyePos.RemoveAt(0);
            leftEyeRot.RemoveAt(0);
            rightEyeRot.RemoveAt(0);
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
