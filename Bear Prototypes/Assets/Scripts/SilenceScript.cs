using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilenceScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().SilenceTheme.TransitionTo(8f);
    }

}
