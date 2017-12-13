using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplePickup : MonoBehaviour {




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.parent = other.transform;
        }

        if (other.tag == "DropZone")
        {
            transform.parent = null;
            this.gameObject.SetActive(false);
        }
    }

}
