using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterPlug : MonoBehaviour {

    public GameObject waterPool1;
    public GameObject waterPool2;

    private Vector3 pool1Start;
    private Vector3 pool2Start;

    private void Start()
    {
        pool1Start = waterPool1.transform.position;
        pool2Start = waterPool2.transform.position;
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.tag == "Plug")
       //{



            print("unplugged!!");
            waterPool1.transform.position = new Vector3(waterPool1.transform.position.x, pool1Start.y - 5, waterPool1.transform.position.z);
            waterPool2.transform.position = new Vector3(waterPool2.transform.position.x, pool2Start.y + 5, waterPool2.transform.position.z);
        //}
        //this.gameObject.SetActive(false);
    }
}
