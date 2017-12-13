using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForthScript : MonoBehaviour {


    public float StartingPoint;
    private float max;
    public float distanceToRight;
    public float speed;


    void Start()
    {

        StartingPoint = transform.position.x;
        max = transform.position.x + distanceToRight;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, max - StartingPoint) + StartingPoint, transform.position.y, transform.position.z);
    }


}
