using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tampil : MonoBehaviour {

    private bool _waiting;
    private float _waitTimer;
    public GameObject bintang;
	// Use this for initialization
	void Start () {
        _waiting = true;
        _waitTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (_waiting)
        {
            _waitTimer += Time.deltaTime;
            if (_waitTimer >= 1.5)
            {
                bintang.SetActive(false);
                _waiting = false;
            }
        }
	}
}
