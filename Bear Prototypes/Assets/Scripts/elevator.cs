using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {

    Vector3 Movement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(MoveElevator());
        }
    }

    IEnumerator MoveElevator()
    {
        while (transform.position.y < -38.58f)
        {
            Movement.y = 3f * Time.deltaTime;
            transform.Translate(Movement);
            yield return null;
        }
    }
}
