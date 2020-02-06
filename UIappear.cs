using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIappear : MonoBehaviour {

    
    [SerializeField] private GameObject panelPesanan;
    [SerializeField] private GameObject panelMasak;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelPesanan.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelPesanan.SetActive(false);
            panelMasak.SetActive(false);
        }
    }
}
