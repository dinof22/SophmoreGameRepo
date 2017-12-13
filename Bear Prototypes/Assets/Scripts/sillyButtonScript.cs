using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sillyButtonScript : MonoBehaviour {

    public GameObject buttonPlatform;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buttonPlatform.SetActive(true);
        }

    }
}
