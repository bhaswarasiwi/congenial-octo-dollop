using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class NPCSimplePatrol : MonoBehaviour {

    Animator anim;

    public ThirdPersonCharacter character;

    //Dictates whether the agent waits on each node.
    [SerializeField]
    bool _patrolWaiting;

    //The total time we wait at each node.
    [SerializeField]
    float _totalWaitTime = 3f;

    //The probability of switching direction.
    [SerializeField]
    float _switchProbability = 0.2f;

    //The list of all patrol nodes to visit.
    [SerializeField]
    List<Waypoint> _patrolPoints;

    //Private variables for base behaviour.
    NavMeshAgent _navMeshAgent;
    int _currentPatrolIndex;
    bool _travelling;
    bool _waiting;
    bool _patrolForward;
    bool _isWalkingTowards = true;
    bool _sittingOn = false;
    float _waitTimer;
    private Vector3 offsetPosition;
    private float moveSpeed;

    // Use this for inittialization
    public void Start()
    {
        anim = character.GetComponent<Animator>();

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        _navMeshAgent.updateRotation = false;

        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
        }
        else
        {
            if(_patrolPoints != null && _patrolPoints.Count >= 1)
            {
                _currentPatrolIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("Insufficient patrol points for basic patrolling behaviour.");
            }
        }
    }

    public void Update()
    {
        //Check if we're close to the destination.
        if(_travelling && _navMeshAgent.remainingDistance <= 0.3f)
        {
            _travelling = false;
            /*anim.SetTrigger("isSitting");*/

            //If we're going to wait, then wait.
            if (_patrolWaiting)
            {
                _waiting = true;
                _waitTimer = 0f;
            }
            else
            {
                _sittingOn = false;
                ChangePatrolPoint();
                SetDestination();
                /*anim.SetTrigger("isWalking");*/
            }
        }

        //Instead if we're waiting.
        if(_waiting)
        {
            character.Move(Vector3.zero, false, false);
            _waitTimer += Time.deltaTime;
            _sittingOn = true;
            if(_sittingOn = true)
            {
                
                if (_waitTimer >= _totalWaitTime)
                {   
                    _waiting = false;
                    ChangePatrolPoint();
                    _sittingOn = false;
                    SetDestination();
                    /*anim.SetTrigger("isWalking");*/
                }
            }
            
        }
        if (_navMeshAgent.remainingDistance > _navMeshAgent.stoppingDistance)
        {
            character.Move(_navMeshAgent.desiredVelocity, false, false);
            
        }
        /*else
        {
            
        }*/

    }

    private void SetDestination()
    {
        anim = character.GetComponent<Animator>();
        if (_patrolPoints != null)
        {
                Vector3 targetVector = _patrolPoints[_currentPatrolIndex].transform.position;
                _navMeshAgent.SetDestination(targetVector);
                _travelling = true;
        }
    }

    /// <summary>
    /// Selects a new patrol point in the available list, but
    /// also with a small probability allows for us to move forwards and backwards.
    /// </summary>
    /// <summary>


   private void ChangePatrolPoint()
    {
       /* if (UnityEngine.Random.Range(0f, 1f) <= _switchProbability)
        {
            _patrolForward = _patrolForward;
        }

        if(_patrolForward)
        {
            /*
            _currentPatrolIndex++;

            if(_currentPatrolIndex >= _patrolPoints.Count)
            {
                _currentPatrolIndex = 0;
            }*/


            _currentPatrolIndex = (_currentPatrolIndex + 1) % _patrolPoints.Count;
        /* }
         else
         {
             /*
             _currentPatrolIndex--;

             if(_currentPatrolIndex < 0)
             {
                 _currentPatrolIndex = _patrolPoints.Count - 1;
             }


             if (--_currentPatrolIndex < 0)
             {
                 _currentPatrolIndex = _patrolPoints.Count - 1;
             }
         }*/
    }

    public void Stop()
    {
        
        Debug.Log("STOP!");
    }

}
