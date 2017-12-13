using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class newGrapScript : MonoBehaviour {

    GameObject player;

    public static Action KeepGravity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveInput.Grab += GrabHandler;
            player = other.gameObject;
            MoveInput.offGrab += offGrabHandler;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            KeepGravity();
            MoveInput.Grab -= GrabHandler;
        }
    }


    void GrabHandler()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        transform.parent = player.transform;
    }

    void offGrabHandler()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        transform.parent = null;
        KeepGravity();
    }
}
