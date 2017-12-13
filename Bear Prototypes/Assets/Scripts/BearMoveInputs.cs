using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BearMoveInputs : MonoBehaviour {


    public static Action<float> BearKeyAction;

    public static Action BearJumpAction;
    public static Action BearConstantAction;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            BearJumpAction();
        }


        if (BearKeyAction != null)
        {
            BearKeyAction(Input.GetAxis("Horizontal2"));
        }


        if (BearConstantAction != null)
        {
            BearConstantAction();
        }


        //if (transform.position.z != -2.95)
        //{
        //    StartCoroutine(resetZPosition());
        //}
    }

    //private IEnumerator resetZPosition()
    //{
    //    yield return new WaitForSeconds(5);
    //    transform.position = new Vector3(transform.position.x, transform.position.y, -2.95f);
    //    yield return new WaitForSeconds(3);
    //}
}
