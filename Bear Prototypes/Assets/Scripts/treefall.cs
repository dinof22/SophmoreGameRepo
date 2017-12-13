using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treefall : MonoBehaviour {


    public GameObject tree2, tree3, tree4, tree5, tree6;

    private Vector3 startPosition;
    private Vector3 startRotation;


    private void Start()
    {

        ObjectStartingPoints.ResetAllObjects += ResetAllObjectsHandler;
        startPosition = this.transform.position;
        startRotation = this.transform.eulerAngles;
    }

    private void OnDestroy()
    {
        ObjectStartingPoints.ResetAllObjects -= ResetAllObjectsHandler;
        Destroy(tree2);
        Destroy(tree3);
        Destroy(tree4);
        Destroy(tree5);
        Destroy(tree6);

    }


    void ResetAllObjectsHandler()
    {
        //this.transform.position = startPosition;
        //this.transform.eulerAngles = startRotation;
        //this.GetComponent<Rigidbody>().useGravity = false;
        //this.GetComponent<Rigidbody>().isKinematic = true;
        Instantiate(Resources.Load("Prefabs/tree (1)"), new Vector3(340.8f, -5.4577f, 0), Quaternion.Euler(startRotation));
        Destroy(this.gameObject);
    }





    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("circleDestroyer"))
        { 
        print("tree has been hit!!!");
            this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<Rigidbody>().useGravity = true;

        }
        if (collision.gameObject.CompareTag("cubeDestroyer"))
        {
            print("bruh");
            this.transform.DetachChildren();
            tree2.AddComponent<Rigidbody>();
            tree3.AddComponent<Rigidbody>();
            tree4.AddComponent<Rigidbody>();
            tree5.AddComponent<Rigidbody>();
            tree6.AddComponent<Rigidbody>();

        }
    }
}
