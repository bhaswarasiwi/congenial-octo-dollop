﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter6 : MonoBehaviour
{

    public GameObject enter;
    public GameObject enter1;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("NPC"))
        {
            enter.SetActive(false);
            enter1.SetActive(true);
            other.GetComponent<NPCSimplePatrol>().enabled = false;
            other.GetComponent<duduk6>().enabled = true;

        }
    }

}
