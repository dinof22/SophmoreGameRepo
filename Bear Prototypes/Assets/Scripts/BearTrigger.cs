using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BearTrigger : MonoBehaviour {

    public GameObject Bear;


    private void Start()
    {
        Bear.GetComponent<bearBackAndForthScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("RRRAWWWWRRRR");
            MoveInput.constantAction += Bear.GetComponent<bearBackAndForthScript>().Move;
            FindObjectOfType<AudioManager>().Play("BearRoar");
            FindObjectOfType<AudioManager>().ChaseTheme.TransitionTo(.3f);

            //Bear.GetComponent<bearBackAndForthScript>().enabled = true;
            //Bear.GetComponent<bearBackAndForthScript>().speed = 7.5f;
            //Bear.transform.position = new Vector3(371f, -34.9f, -2.95f);
        }
    }
}
