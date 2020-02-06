using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit1 : MonoBehaviour
{

    public GameObject zone;
    public GameObject zone2;
    public GameObject zone3;
    bool _waiting;
    float _waitTimer;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            _waiting = true;
            _waitTimer = 0f;
        }


    }

    public void Update()
    {
        if (_waiting)
        {
            _waitTimer += Time.deltaTime;
            if (_waitTimer >= 5)
            {
                zone.SetActive(false);
                zone2.SetActive(true);
                zone3.SetActive(true);
                _waiting = false;
            }


        }
    }
}

