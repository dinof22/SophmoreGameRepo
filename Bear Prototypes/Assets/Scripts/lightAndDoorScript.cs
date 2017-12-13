using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class lightAndDoorScript : MonoBehaviour {


    Vector3 Movement;

    private void Awake()
    {
        LastLight.openTheDangDoor += OpenDoorHandler;
    }

    void OpenDoorHandler()
    {
        StartCoroutine(MoveDoorDown());
    }

    IEnumerator MoveDoorDown()
    {
        while (transform.position.y > -353.62f)
        {
            Movement.y = -3f * Time.deltaTime;
            transform.Translate(Movement);
            yield return null;
        }
    }
}
