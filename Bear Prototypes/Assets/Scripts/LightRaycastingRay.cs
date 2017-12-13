using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightRaycastingRay : MonoBehaviour {


    public static Action turnOffLight;
    public static Action turnOnLight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Light")
        {
            turnOnLight();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Light")
        {
            turnOffLight();
        }
    }



}
