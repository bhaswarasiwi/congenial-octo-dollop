using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideMenu : MonoBehaviour {

    // The target marker.
    public Transform target;
    public Transform awal;



    // Speed in units per sec.
    public float speed;
    bool _slide;

    void Update()
    {
        if (_slide)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.LerpUnclamped(transform.position, target.position, step);
        }
        else
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, awal.position, step);
        }
        
    }

    public void Pinda()
    {
        // The step size is equal to speed times frame time.

        if (!_slide)
        {
            _slide = true;
        }
        else
        {
            _slide = false;
        }
        
        
    }
}
