using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaxThemeScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().RelaxTheme.TransitionTo(5f);
    }
}
