using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneScript : MonoBehaviour {

    public GameObject redPickup, BluePickup, WinningPortal;
    private int totalPickups = 0;


    private void Start()
    {
        ObjectStartingPoints.ResetAllObjects += makeTotalPickupsZero;
        redPickup.SetActive(false);
        BluePickup.SetActive(false);
        WinningPortal.SetActive(false);
    }

    private void makeTotalPickupsZero()
    {
        totalPickups = 0;
        WinningPortal.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BluePickup")
        {
            BluePickup.SetActive(true);
            totalPickups++;
            areThereTwoPickups();
        }

        if (other.tag == "RedPickup")
        {
            redPickup.SetActive(true);
            totalPickups++;
            areThereTwoPickups();
        }
    }

    private void areThereTwoPickups()
    {
        if (totalPickups == 2)
        {
            print("YOU GOT BOTH PICKUPS!!!");
            WinningPortal.SetActive(true);
        }
    }
}
