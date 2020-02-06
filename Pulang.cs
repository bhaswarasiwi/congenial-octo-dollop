using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Pulang : MonoBehaviour {

    public ThirdPersonCharacter character;
    
    NavMeshAgent _navMeshAgents;
    private float _waitTimer;
    private bool _waiting;

    public void Start()
    {
        
        _navMeshAgents = this.GetComponent<NavMeshAgent>();
        
        
    }
    // Update is called once per frame
    void Update () {

        if (_waiting)
        {
            
            _waitTimer += Time.deltaTime;
           
            if (_waitTimer >= 0.5)
            {
                Destroy(character.gameObject);
                _waiting = false;
            }
        }

        
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mkn1"))
        {
            _waiting = true;
            _waitTimer = 0f;
        }
    }

}
