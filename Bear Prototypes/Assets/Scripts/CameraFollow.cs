using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform camTarget;

    public Vector3 camOffset;

    private void Update()
    {
        FollowTarget();
    }

    void FollowTarget() {
        this.transform.position = Vector3.Lerp(transform.position, camTarget.position + camOffset, .999f);
        transform.LookAt(camTarget);
    }

}
