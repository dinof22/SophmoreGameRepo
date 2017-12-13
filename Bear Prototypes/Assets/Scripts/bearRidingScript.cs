using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearRidingScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.parent = this.transform;
            CharacterMovement.RidingBear = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            other.transform.parent = null;
            CharacterMovement.RidingBear = false;
        }
    }
}
