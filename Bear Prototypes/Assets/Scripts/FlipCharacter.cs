using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour {

    Quaternion myRotate;

    Vector3 rotValue;


    private void Start()
    {
        MoveInput.KeyAction += Flip;
    }

    private void Flip(float obj)
    {
        if (obj > 0)
        {
            rotValue.y = 0;
        }
        if (obj < 0)
        {
            rotValue.y = 180;
        }

        myRotate.eulerAngles = rotValue;
        transform.localRotation = myRotate;
    }
}
