using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollider : MonoBehaviour {

    [SerializeField] private GameObject panelPesanan;
    [SerializeField] private GameObject panelPesanan2;

    public static int makan;
    [SerializeField] public int b;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelPesanan.SetActive(true);
            makan = b;
        }
    }

    void OnTriggerExit(Collider other)
    {
        panelPesanan.SetActive(false);
        panelPesanan2.SetActive(false);
        makan = 0;
    }
    
    
}
