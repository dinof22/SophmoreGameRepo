using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EasyChasePlayer : MonoBehaviour {

    public NavMeshAgent agent;

    public Transform player;

    private void Update()
    {
        agent.destination = player.position;
    }
}
