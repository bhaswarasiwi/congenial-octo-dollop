using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public GameObject Panel1, Panel2;

    public void menumasak(GameObject instance)
    {
        keluarpanel1();
    }

    public void keluarpanel1()
    {
        Panel1.SetActive(true);
    }

    public void resume()
    {
        Panel1.SetActive(false);
        Time.timeScale = 1;
    }
}
