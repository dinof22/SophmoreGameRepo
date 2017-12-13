using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAnimatorScript : MonoBehaviour {

    public Animator animator;
    public static bool Speed;
    public static bool Chasing;


    private void Start()
    {
        animator = GetComponent<Animator>();
        BearMoveInputs.BearKeyAction += Animate;
    }

    private void Animate(float obj)
    {
        animator.SetFloat("Speed", obj);
        animator.SetBool("Chasing", Chasing);
    }
}
