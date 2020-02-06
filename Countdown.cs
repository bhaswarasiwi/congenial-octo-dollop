using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class Countdown : MonoBehaviour {

    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    public GameObject times;
    public GameObject waktu;
    public GameObject selesai;
    public GameObject spawner;

    public GameObject centang1;
    public GameObject centang2;
    public GameObject centang3;

    public GameObject bintang1;
    public GameObject bintang2;
    public GameObject bintang3;


    void Update () {
		if(timer >= 0.0f && canCount)
        {
            float t = timer -= Time.deltaTime;

            /*timer -= Time.deltaTime;
            uiText.text = timer.ToString("F0");*/
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f0");
            uiText.text = minutes + ":" + seconds;
        }

        else if(timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "";
            timer = 0.0f;
            times.SetActive(true);
            waktu.SetActive(false);
            selesai.SetActive(false);
            spawner.SetActive(false);
            centang1.SetActive(false);
            centang2.SetActive(false);
            centang3.SetActive(false);
            if (shopBeli.memasak >= 1 && shopBeli.memesan >= 10 && shopBeli.meminum >= 1)
            {
                bintang3.SetActive(true);
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
            else if (shopBeli.memasak >= 1 && shopBeli.memesan >= 10)
            {
                bintang2.SetActive(true);
                Debug.Log("bintang2");
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
            else if (shopBeli.memasak >= 1 && shopBeli.meminum >= 1)
            {
                bintang2.SetActive(true);
                Debug.Log("bintang2");
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
            else if (shopBeli.memesan >= 10 && shopBeli.meminum >= 1)
            {
                bintang2.SetActive(true);
                Debug.Log("bintang2");
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
            else if (shopBeli.memasak >= 1)
            {
                bintang1.SetActive(true);
                Debug.Log("bintang1");
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
            else if (shopBeli.memesan >= 10)
            {
                bintang1.SetActive(true);
                Debug.Log("bintang1");
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
            else if (shopBeli.meminum >= 1)
            {
                bintang1.SetActive(true);
                Debug.Log("bintang1");
                shopBeli.memasak = 0;
                shopBeli.meminum = 0;
                shopBeli.memesan = 0;
            }
        }
	}

    public void Selesai()
    {
        timer = 0.0f;
    }
    public void ResetBtn()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
    }
}
