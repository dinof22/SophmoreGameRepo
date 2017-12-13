using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnTrigger : MonoBehaviour {

    public GameObject player;


    CharacterMovement cc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cc = player.gameObject.GetComponent<CharacterMovement>();
            other.transform.position = cc.respawnPoint.position;
            FindObjectOfType<AudioManager>().Play("DeathFall");
        }
    }

}
