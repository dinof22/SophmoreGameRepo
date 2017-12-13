using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStatue : MonoBehaviour {

    public static Action<int, float> StatueRotated;

    public Transform statueRotation;
    private Vector3 startPosition;
    private Vector3 EndPosition;
    private float percentRotated;
    public float RotateTime = 1f, rotAngle = 90f;
    private bool playerWithin = false;
    public int StatueID; //0 for left, 2 for right

    private void Start()
    {
        RotateTime = 1f; rotAngle = 90f;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveInput.RotateClockwise += RotateClockwiseHandler;
            MoveInput.RotateCounterClockwise += RotateCounterClockwiseHandler;
            playerWithin = true;
            //print("player is now using " + this.gameObject.name + "!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveInput.RotateClockwise -= RotateClockwiseHandler;
            MoveInput.RotateCounterClockwise -= RotateCounterClockwiseHandler;
            playerWithin = false;
            //print("player is no longer using " + this.gameObject.name + "!");
        }
    }




    private void RotateCounterClockwiseHandler(bool _pressed1)
    {
        if (_pressed1)
        {
            StartCoroutine(RotateStatueMethod(-rotAngle));
            //print("player has activated " + this.gameObject.name + "!");
        }
        if (!_pressed1)
        {
            //print("you let go of number 1");
        }
    }



    private void RotateClockwiseHandler(bool _pressed2)
    {
        if (_pressed2)
        {
            StartCoroutine(RotateStatueMethod(rotAngle));
            //print("player has activated " + this.gameObject.name + "!");

        }
        if (!_pressed2)
        {
            //print("you let go of number 2");
        }
    }

    IEnumerator RotateStatueMethod(float _rotAngle) {
        MoveInput.RotateClockwise -= RotateClockwiseHandler;
        MoveInput.RotateCounterClockwise -= RotateCounterClockwiseHandler;
        percentRotated = 0f;
        //print(percentRotated);
        startPosition = statueRotation.rotation.eulerAngles;
        EndPosition = startPosition;
        EndPosition.y = startPosition.y + _rotAngle;
        while (percentRotated < 1)
        {
            percentRotated += (1 / RotateTime) * Time.deltaTime;
            //print((1 / RotateTime) * Time.deltaTime);
            //print(percentRotated);
            statueRotation.rotation = Quaternion.Euler(Vector3.Lerp(startPosition, EndPosition, percentRotated));
            yield return null;
        }
        if (StatueRotated != null) { StatueRotated(StatueID, statueRotation.rotation.y); }
        if (playerWithin) {
            MoveInput.RotateClockwise += RotateClockwiseHandler;
            MoveInput.RotateCounterClockwise += RotateCounterClockwiseHandler;
            }
        }
    }
