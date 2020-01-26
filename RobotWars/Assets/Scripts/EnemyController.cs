using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject protecctionPoint;
    [SerializeField] private int aggroRange = 12;
    private Vector3 targetDistance;
    // Update is called once per frame
    void Update()
    {
        ActivateAggroMode();
    }

    private void ActivateAggroMode() {
        targetDistance = target.transform.position - gameObject.transform.position;
        if (targetDistance.magnitude < aggroRange) {
            agent.SetDestination(target.transform.position);
        }
        else
            agent.SetDestination(protecctionPoint.transform.position);
    }
}
