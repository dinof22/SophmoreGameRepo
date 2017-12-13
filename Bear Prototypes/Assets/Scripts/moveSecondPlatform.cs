using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSecondPlatform : MonoBehaviour
{

    Vector3 Movement;
    public GameObject SecondPlatform;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(MovePlatformDown());
        }
        
    }


IEnumerator MovePlatformDown()
{
    while (SecondPlatform.transform.position.y > -312)
    {
        Movement.y = -3f * Time.deltaTime;
        SecondPlatform.transform.Translate(Movement);
        yield return null;
    }
}
}
