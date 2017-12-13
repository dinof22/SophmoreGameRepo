using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


    [RequireComponent(typeof(NavMeshAgent))]

public class BetterEnemyChase : MonoBehaviour {



    private NavMeshAgent agent;

    private Transform player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        sendPositionToEnemy.SendTransform += SendTransformHandler;
    }

    private void SendTransformHandler(Transform _transform)
    {
        player = _transform;
    }

    private void Update()
    {
        agent.destination = player.position;
    }

}
