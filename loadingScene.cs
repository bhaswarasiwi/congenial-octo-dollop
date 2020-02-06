using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loadingScene : MonoBehaviour {
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;

    private void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = 0;
    }

    private void Update()
    {
        if (timeLeft >= 0)
        {
            timeLeft += Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
            if (timeLeft >= 5)
            {
                timeLeft = 0;
            }
        }
        else
        {
            Time.timeScale = 0;
        }
    }

}
