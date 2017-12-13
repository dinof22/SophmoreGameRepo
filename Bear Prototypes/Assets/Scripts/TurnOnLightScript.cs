using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TurnOnLightScript : MonoBehaviour {


    private void Start()
    {
        ObjectStartingPoints.ResetAllObjects += TurnOffLightHandler;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Light")
        {
            TurnOnLightHandler();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Light")
        {
            TurnOffLightHandler();
        }

    }






    public void TurnOnLightHandler()
    {
        //print(this.transform.GetChild(0).name);
        this.transform.GetChild(0).gameObject.SetActive(true);
        //thisObjectsLight.SetActive(true);
    }

    public void TurnOffLightHandler()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        //thisObjectsLight.SetActive(false);
    }

}
