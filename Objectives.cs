using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour {

    public GameObject centang1;
    public GameObject centang2;
    public GameObject centang3;

    void Start () {
		
	}
	void Update () {
        if (shopBeli.memesan >= 10)
        {
            centang1.SetActive(true);

        }

        if (shopBeli.memasak >= 1)
        {
            centang2.SetActive(true);
        }

        if (shopBeli.meminum >= 1)
        {
            centang3.SetActive(true);
        }

    }

}
