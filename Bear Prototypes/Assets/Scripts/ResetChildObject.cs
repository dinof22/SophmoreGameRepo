using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetChildObject : MonoBehaviour {

    private Vector3 startPosition;
    private Vector3 startRotation;


    private void Start()
    {

        ObjectStartingPoints.ResetAllObjects += ResetAllObjectsHandler;
        startPosition = this.transform.localPosition;
        startRotation = this.transform.localEulerAngles;
    }


    void ResetAllObjectsHandler()
    {
        this.transform.localPosition = startPosition;
        this.transform.localEulerAngles = startRotation;
    }
}
