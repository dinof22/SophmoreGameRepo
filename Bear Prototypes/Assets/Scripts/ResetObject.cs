using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour {

    private Vector3 startPosition;
    private Vector3 startRotation;


    private void Start()
    {

        ObjectStartingPoints.ResetAllObjects += ResetAllObjectsHandler;
        startPosition = this.transform.position;
        startRotation = this.transform.eulerAngles;
    }


    void ResetAllObjectsHandler()
    {
        this.transform.position = startPosition;
        this.transform.eulerAngles = startRotation;
    }
}
