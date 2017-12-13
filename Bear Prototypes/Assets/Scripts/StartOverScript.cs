using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOverScript : MonoBehaviour {

    public GameObject Player;
    public void movePlayerToStart()
    {
        Player.transform.position = new Vector3(0, 2, 0);
    }

}
