using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudScript : MonoBehaviour {

    public GameObject player;
    public GameObject bear;

    CharacterMovement cc;
    BearMovement bcc;

    private float fakeGravity;

    private void Start()
    {
        cc = player.gameObject.GetComponent<CharacterMovement>();
        bcc = bear.gameObject.GetComponent<BearMovement>();
        //print(cc.gravity);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cc.gravity = 5f;
            cc.inWater = false;
            cc.doubleJump = false;
            cc.speed = 2f;
            cc.jumpHeight = 1f;
            cc.resetGravity();
        }
        if (other.tag == "Bear")
        {
            bcc.gravity = 5f;
            bcc.inWater = false;
            bcc.doubleJump = false;
            bcc.speed = 2f;
            bcc.jumpHeight = 1f;
            bcc.resetGravity();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            cc.inWater = false;
            cc.gravity = 40f;
            cc.speed = 8f;
            cc.jumpHeight = 15f;
            cc.doubleJump = true;
        }
        if (other.tag == "Bear")
        {
            bcc.inWater = false;
            bcc.gravity = 40f;
            bcc.speed = 8f;
            bcc.jumpHeight = 15f;
            bcc.doubleJump = true;
        }
    }
}

