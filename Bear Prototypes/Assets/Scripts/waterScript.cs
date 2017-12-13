using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterScript : MonoBehaviour {

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
            cc.inWater = true;
            cc.doubleJump = true;
            cc.speed = 5;
            cc.jumpHeight = 3;
            cc.resetGravity();
            AnimatorScript.InWater = true;
            FindObjectOfType<AudioManager>().Play("Splash");
        }
        if (other.tag == "Bear")
        {
            bcc.gravity = 5f;
            bcc.inWater = true;
            bcc.doubleJump = true;
            bcc.speed = 5;
            bcc.jumpHeight = 3;
            bcc.resetGravity();
            FindObjectOfType<AudioManager>().Play("Splash");
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
            AnimatorScript.InWater = false;
        }
        if (other.tag =="Bear")
        {
            bcc.inWater = false;
            bcc.gravity = 40f;
            bcc.speed = 8f;
            bcc.jumpHeight = 15f;
            bcc.doubleJump = true;
        }
    }
}
