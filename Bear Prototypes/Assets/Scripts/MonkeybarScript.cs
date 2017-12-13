using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MonkeybarScript : MonoBehaviour {

    public GameObject player;

    CharacterMovement cc;

    //private float fakeGravity;

    private void Start()
    {
        cc = player.gameObject.GetComponent<CharacterMovement>();
        //print(cc.gravity);
        
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        if (Input.GetKeyDown(KeyCode.LeftControl))
    //        {
    //            print("controlPressed");
    //           cc.gravity = 0f;
    //        }
    //        if (Input.GetKeyUp(KeyCode.LeftControl))
    //        {
    //            print("left control released!!");
    //            cc.gravity = 40f;
    //        }
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        cc.gravity = 40f;
    //    }
    //}




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
            MoveInput.Grab -= GrabHandler;
            cc.gravity = 40f;
        }
    }

    private void GrabHandler()
    {
        cc.gravity = 0f;
    }

    private void offGrabHandler()
        {
        cc.gravity = 40f;
        }

}
