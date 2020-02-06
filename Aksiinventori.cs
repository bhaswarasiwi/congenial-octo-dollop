using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aksiinventori : MonoBehaviour {

    public GameObject panelpause;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void open()
    {
        panelpause.SetActive(true);
        Time.timeScale = 0;
       
    }

    public void close()
    {
        panelpause.SetActive(false);
        Time.timeScale = 1;
    }
}
