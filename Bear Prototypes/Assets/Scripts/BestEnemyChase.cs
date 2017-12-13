using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class BestEnemyChase : MonoBehaviour {

    private NavMeshAgent agent;
    private Transform player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        sendPositionToEnemy.SendTransform += SendTransformHandler;
        StartCoroutine(Follow());
    }

    private void SendTransformHandler(Transform _transform)
    {
        player = _transform;
    }

    IEnumerator Follow()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            agent.destination = player.position;
        }
    }
}
