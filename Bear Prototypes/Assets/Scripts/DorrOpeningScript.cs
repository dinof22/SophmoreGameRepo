using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DorrOpeningScript : MonoBehaviour {

    Vector3 Movement;

    private void Awake()
    {
        DoubleButtonScript.OpenDoor += OpenDoorHandler;
    }

    void OpenDoorHandler()
    {
        StartCoroutine(MoveDoorDown());
    }

    IEnumerator MoveDoorDown()
    {
        while (transform.position.y > -136)
        {
            Movement.y = -3f * Time.deltaTime;
            transform.Translate(Movement);
            yield return null;
        }
    }
}
