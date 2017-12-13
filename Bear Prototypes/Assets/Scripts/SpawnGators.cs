using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGators : MonoBehaviour {


    public GameObject GatorGate1, GatorGate2, GatorGate3;



    private void OnTriggerEnter(Collider other)
    {
        GatorGate1.SetActive(false);
        GatorGate2.SetActive(false);
        GatorGate3.SetActive(false);

        FindObjectOfType<AudioManager>().SwampTheme.TransitionTo(5f);
    }
}
