using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCharacterYPosition : MonoBehaviour {




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(transform.position.x, transform.position.y,0);
        }
        if (other.tag == "Bear")
        {
            other.transform.position = new Vector3(transform.position.x, transform.position.y, -2.95f);
        }
    }
}
