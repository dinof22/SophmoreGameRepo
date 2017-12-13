using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleThemeScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("TempleSting");
        FindObjectOfType<AudioManager>().TempleTheme.TransitionTo(5f);
    }
}
