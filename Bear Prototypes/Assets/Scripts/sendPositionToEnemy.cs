using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sendPositionToEnemy : MonoBehaviour {


    public static Action<Transform> SendTransform;

	void Start () {
        SendTransform(transform);
	}
	
}
