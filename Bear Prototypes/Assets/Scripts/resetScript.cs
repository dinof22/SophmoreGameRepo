using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScript : MonoBehaviour {

    public GameObject player;


    CharacterMovement cc;

    private void OnTriggerEnter(Collider other)
    {
        respawnPlayer();
    }

    public void respawnPlayer()
    {
        cc = player.gameObject.GetComponent<CharacterMovement>();
        cc.respawnPoint = this.transform;
    }

}
