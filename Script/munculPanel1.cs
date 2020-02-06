using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculPanel1 : MonoBehaviour {
    


    public void OnTriggerEnter()
    {
        GameManager.instance.menumasak(gameObject);
            
    }
}
