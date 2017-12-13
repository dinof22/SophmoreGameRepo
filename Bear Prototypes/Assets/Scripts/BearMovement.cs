using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BearMovement : MonoBehaviour {

    CharacterController cc;

    public static Vector3 tempMove;

    public float speed;
    public float gravity;
    public float jumpHeight;
    [HideInInspector] public bool doubleJump;
    public bool inWater;

    private Action onLandAction;


    public Transform respawnPoint;





    void Start()
    {
        cc = GetComponent<CharacterController>();
        BearMoveInputs.BearJumpAction += Jump;
        BearMoveInputs.BearKeyAction += Move;
        doubleJump = false;
        inWater = false;

    }





    void Jump()
    {

        if (cc.isGrounded)
        {
            print("Jump");
            tempMove.y = jumpHeight;
            doubleJump = true;
        }
        else
        {
            if (doubleJump)
            {
                if (inWater)
                {
                    print("waterJump!!");
                    tempMove.y = jumpHeight;
                    doubleJump = true;
                }
                else
                {
                    print("Jump");
                    tempMove.y = jumpHeight;
                    doubleJump = false;
                }
            }
        }
    }


    void Move(float _movement)
    {

        tempMove.x = _movement * speed;
        cc.Move(tempMove * Time.deltaTime);
        if (!cc.isGrounded)
        {
            tempMove.y -= gravity * Time.deltaTime;
            if (onLandAction == null)
            {
                onLandAction += resetGravity;
            }
        }
        if (cc.isGrounded)
        {
            if (onLandAction != null)
            {
                onLandAction();
                onLandAction = null;
            }
        }


    }


    [HideInInspector]
    public void resetGravity()
    {
        tempMove.y = -.1f;
    }
}
