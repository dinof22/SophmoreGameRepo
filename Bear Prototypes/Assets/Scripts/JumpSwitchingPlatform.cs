using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JumpSwitchingPlatform : MonoBehaviour {


    public bool infront;
    Vector3 Movement, tempPos, finalPos;
    private int jumpCount;



	void Start () {
        MoveInput.JumpAction += JumpActionHanlder;
        CharacterMovement.PlayerGroundedAction += PlayerGroundedHandler;
	}

    private void PlayerGroundedHandler()
    {
        jumpCount = 1;
    }

    private void JumpActionHanlder()
    {
        print("Jump");
        if (jumpCount <= 2)
        {
            jumpCount++;
            if (infront)
            {
                StartCoroutine(MoveToBack());


            }
            else
            {
                StartCoroutine(MoveToFront());
            }
        }
    }


    IEnumerator MoveToBack()
    {
        MoveInput.JumpAction -= JumpActionHanlder;
        finalPos = transform.position;
        finalPos.z += 7f;
        transform.position = finalPos;
        yield return null;
        MoveInput.JumpAction += JumpActionHanlder;
        infront = false;
    }
    IEnumerator MoveToFront()
    {
        MoveInput.JumpAction -= JumpActionHanlder;
        finalPos = transform.position;
        finalPos.z += -7f;
        transform.position = finalPos;
        yield return null;
        MoveInput.JumpAction += JumpActionHanlder;
        infront = true;
    }


}
