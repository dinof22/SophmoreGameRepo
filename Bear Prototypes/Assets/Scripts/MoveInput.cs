using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

    public GameObject Bear;


    private bool gameIsPaused = false;
    public GameObject PauseMenu;
    public GameObject StartMenu;
    public GameObject PlayerArt;

    public static Action<float> KeyAction;


    public static Action JumpAction;
    public static Action Grab;
    public static Action offGrab;
    public static Action constantAction;
    public static Action CenterPlayers;


    public static Action<bool> RotateClockwise;
    public static Action<bool> RotateCounterClockwise;



  


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        }

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused == false)
            {
                print("Freezing Time and space");
                Time.timeScale = 0;
                PauseMenu.SetActive(true);
                gameIsPaused = true;
            }
            else
            {
                print("Unfreeezing timeand space");
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
                gameIsPaused = false;
            }


        }



        if (KeyAction != null)
        {
            KeyAction(Input.GetAxis("Horizontal"));
        }





        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (Grab != null)
            {
                Grab();
                AnimatorScript.Grabbing = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            if (offGrab != null)
            {
                offGrab();
                AnimatorScript.Grabbing = false;
            }
        }



        if (RotateClockwise != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                RotateClockwise(true);
            }

            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                RotateClockwise(false);
            }
        }


        if (RotateCounterClockwise != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                RotateCounterClockwise(true);
            }
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                RotateCounterClockwise(false);
            }
        }





        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //this.transform.localPosition -= new Vector3(0, .5f, 0);
            this.transform.localScale = new Vector3(1f, 0.5f, 1f);
            AnimatorScript.Crouching = true;
            PlayerArt.transform.localScale = new Vector3(22f, 44f, 22f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //this.transform.localPosition += new Vector3(0, .5f, 0);
            this.transform.localScale = new Vector3(1f, 1f, 1f);
            AnimatorScript.Crouching = false;
            PlayerArt.transform.localScale = new Vector3(22f, 22f, 22f);
        }


        if (constantAction != null)
        {
            constantAction();
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            Bear.transform.position = new Vector3(Bear.transform.position.x, Bear.transform.position.y, -2.95f);

        }

        //if (transform.position.z != 0)
        //{
        //    StartCoroutine(resetZPosition());
        //}

        


    }



    //private IEnumerator resetZPosition()
    //{
    //    yield return new WaitForSeconds(5);
    //    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    //    yield return new WaitForSeconds(3);
    //}



}
