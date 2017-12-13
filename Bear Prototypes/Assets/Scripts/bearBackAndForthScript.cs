using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearBackAndForthScript : MonoBehaviour {
    private float speed = 7.5f;
    public float maxDistance;
 

    public void Move()
    {
        if (transform.position.x <= maxDistance) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            BearAnimatorScript.Chasing = true;
        }
        else
        {
            MoveInput.constantAction -= Move;
            BearAnimatorScript.Chasing = false;
        }
    }


 
}
