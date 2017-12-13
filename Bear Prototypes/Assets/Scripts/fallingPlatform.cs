using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour {

    

    public GameObject ThisPlatform;

    Vector3 startingPoint;

    bool touchedOnce = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (touchedOnce)
            {
                touchedOnce = false;
                startingPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                StartCoroutine(delayAndFall());
            }
        }
    }

    

        IEnumerator delayAndFall()
        {
            yield return new WaitForSeconds(1f);
            ThisPlatform.AddComponent<Rigidbody>();
            StartCoroutine(delayAndReset());
        }


        IEnumerator delayAndReset()
        {
            yield return new WaitForSeconds(5f);
            Destroy(GetComponent<Rigidbody>());
            transform.position = startingPoint;
            touchedOnce = true;
        }
        

}
