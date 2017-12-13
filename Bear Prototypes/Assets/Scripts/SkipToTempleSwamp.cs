using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipToTempleSwamp : MonoBehaviour {

    public GameObject skipToPoint;
    public GameObject player;
    public GameObject bear;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = skipToPoint.transform.position;
            bear.transform.position = skipToPoint.transform.position;
        }
    }
}
