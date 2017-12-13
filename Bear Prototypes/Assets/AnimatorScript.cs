using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour {

    public Animator animator;
    public float Speed;
    public static bool IsGrounded;
    public static bool Grabbing;
    public static bool Crouching;
    public static bool InWater;



	void Start () {
        animator = GetComponent<Animator>();
        MoveInput.KeyAction += Animate;

	}

    private void Animate(float obj)
    {
        animator.SetFloat("Speed", Mathf.Abs(obj));
        animator.SetBool("IsGrounded", IsGrounded);
        animator.SetBool("Grabbing", Grabbing);
        animator.SetBool("Crouching", Crouching);
        animator.SetBool("InWater", InWater);
    }

}
