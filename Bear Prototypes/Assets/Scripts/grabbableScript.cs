using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class grabbableScript : MonoBehaviour {

    CharacterController cc;

    public GameObject grabHolder;


    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            print("control Pressed");
            //GetComponent<Rigidbody>().useGravity = false;
            //this.transform.position = new Vector3(grabHolder.transform.position.x, grabHolder.transform.position.y, 0f);
            //this.transform.eulerAngles = new Vector3(0, 0, 0);
            this.transform.parent = grabHolder.transform;

        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            print("control let go");
            this.transform.parent = null;
            //GetComponent<Rigidbody>().useGravity = true;
        }


        if (!cc.isGrounded)
        {
            GetComponent<Rigidbody>().useGravity = false;
        }
        if (cc.isGrounded)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }













    //public GameObject SolidCube;



    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        print("you touched teh box");
    //        //SolidCube.transform.position = new Vector3(44, 55, 0);    //this WORKS
    //        if (Input.GetKeyDown(KeyCode.LeftControl))
    //        {
    //            print("grabbing!!!");
    //            //transform.root = cc.gameObject.transform;
    //        }
    //    }
    //}
}
