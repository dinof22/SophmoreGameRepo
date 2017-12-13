using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToUnderground : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") || (other.tag == "Bear"))
        {
            other.transform.Translate(new Vector3(0, -125, 0));
        }
    }
}