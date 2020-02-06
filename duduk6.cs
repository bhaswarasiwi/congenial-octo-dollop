using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class duduk6 : MonoBehaviour
{

    Animator anim;

    public ThirdPersonCharacter character;

    [SerializeField]
    List<Waypoint> _patrolPoints;

    NavMeshAgent _navMeshAgent;

    private GameObject npc;

    void Start()
    {
        anim = character.GetComponent<Animator>();
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        npc = GameObject.FindGameObjectWithTag("NPC");

        if (_patrolPoints != null && _patrolPoints.Count >= 1)
        {
            Vector3 targetVector = _patrolPoints[0].transform.position;
            _navMeshAgent.SetDestination(targetVector);

        }
    }

    void Update()
    {
        if (_navMeshAgent.remainingDistance <= 0.5f)
        {
            anim.SetTrigger("isSitting");
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            character.transform.rotation = _patrolPoints[0].transform.rotation;
            character.transform.position = _patrolPoints[1].transform.position;
            npc.GetComponent<duduk6>().enabled = false;
            npc.GetComponent<Pulang>().enabled = true;
        }
        if (_navMeshAgent.remainingDistance > _navMeshAgent.stoppingDistance)
        {
            character.Move(_navMeshAgent.desiredVelocity, false, false);

        }
    }

}
