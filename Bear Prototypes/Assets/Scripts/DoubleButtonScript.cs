using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoubleButtonScript : MonoBehaviour {


    bool pressed = false;
    public static Action OpenDoor;
    

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player" || other.tag == "Bear") && !pressed)
        {
            PublicVariables.templeDoubleButtonsPressed++;
            print(PublicVariables.templeDoubleButtonsPressed);
            if(PublicVariables.templeDoubleButtonsPressed == 2)
            {
                OpenDoor();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Bear")
        {
            pressed = false;
            PublicVariables.templeDoubleButtonsPressed--;
            print(PublicVariables.templeDoubleButtonsPressed);
        }
    }
}

