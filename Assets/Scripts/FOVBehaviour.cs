using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("LeftQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("RightQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("TopQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("BottomQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("TopLeftQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("TopRightQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("BottomLeftQuad1").GetComponent<Renderer>().enabled = true;
        GameObject.Find("BottomRightQuad1").GetComponent<Renderer>().enabled = true;

        GameObject.Find("LeftQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("RightQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("TopQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("BottomQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("TopLeftQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("TopRightQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("BottomLeftQuad2").GetComponent<Renderer>().enabled = true;
        GameObject.Find("BottomRightQuad2").GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            GameObject.Find("LeftQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("LeftQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("RightQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("RightQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("TopQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("TopQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("BottomQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("TopLeftQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("TopLeftQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("TopRightQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("TopRightQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomLeftQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("BottomLeftQuad1").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomRightQuad1").GetComponent<Renderer>().enabled = !GameObject.Find("BottomRightQuad1").GetComponent<Renderer>().enabled;

            GameObject.Find("LeftQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("LeftQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("RightQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("RightQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("TopQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("TopQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("BottomQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("TopLeftQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("TopLeftQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("TopRightQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("TopRightQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomLeftQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("BottomLeftQuad2").GetComponent<Renderer>().enabled;
            GameObject.Find("BottomRightQuad2").GetComponent<Renderer>().enabled = !GameObject.Find("BottomRightQuad2").GetComponent<Renderer>().enabled;
        }
    }
}
