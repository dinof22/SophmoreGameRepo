using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

    public Transform ClosestMirror;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveInput.RotateClockwise += RotateClockwiseHandler;
            MoveInput.RotateCounterClockwise += RotateCounterClockwiseHandler;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveInput.RotateClockwise -= RotateClockwiseHandler;
            MoveInput.RotateCounterClockwise -= RotateCounterClockwiseHandler;
        }
    }

    private void RotateClockwiseHandler(bool _pressed2)
    {
        if (_pressed2)
        {

            StartCoroutine(RotateOrbCounterClockwise());
            //StartCoroutine(RotateStatueMethod(rotAngle));
            print("player has activated " + this.gameObject.name + "!");

        }
        if (!_pressed2)
        {
            StopAllCoroutines();
            print("you let go of number 2");
        }
    }

    private void RotateCounterClockwiseHandler(bool _pressed1)
    {
        if (_pressed1)
        {
            StartCoroutine(RotateOrbClockwise());
            print("player has activated " + this.gameObject.name + "!");
        }
        if (!_pressed1)
        {
            StopAllCoroutines();
            print("you let go of number 1");
        }
    }


    IEnumerator RotateOrbClockwise()
    {
        while (true)
        {
            ClosestMirror.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
            yield return null;
        }
    }


    IEnumerator RotateOrbCounterClockwise()
    {
        while (true)
        {
            ClosestMirror.Rotate(new Vector3(0, 0, -45) * Time.deltaTime);
            yield return null;
        }
    }

}
