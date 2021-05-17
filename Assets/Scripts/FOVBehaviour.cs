using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("LeftQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("RightQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("TopQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("BottomQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("TopLeftQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("TopRightQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("BottomLeftQuad").GetComponent<Renderer>().enabled = false;
        GameObject.Find("BottomRightQuad").GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            GameObject.Find("LeftQuad").GetComponent<Renderer>().enabled = !GameObject.Find("LeftQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("RightQuad").GetComponent<Renderer>().enabled = !GameObject.Find("RightQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("TopQuad").GetComponent<Renderer>().enabled = !GameObject.Find("TopQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomQuad").GetComponent<Renderer>().enabled = !GameObject.Find("BottomQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("TopLeftQuad").GetComponent<Renderer>().enabled = !GameObject.Find("TopLeftQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("TopRightQuad").GetComponent<Renderer>().enabled = !GameObject.Find("TopRightQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomLeftQuad").GetComponent<Renderer>().enabled = !GameObject.Find("BottomLeftQuad").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomRightQuad").GetComponent<Renderer>().enabled = !GameObject.Find("BottomRightQuad").GetComponent<Renderer>().enabled;
        }
    }
}
