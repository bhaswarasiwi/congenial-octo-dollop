using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    private bool _waiting;
    private float _waitTimer;
    [SerializeField] private GameObject food1;
    [SerializeField] private GameObject trigger1;
    [SerializeField] private GameObject Exit1;
    [SerializeField] private GameObject Enter1;

    [SerializeField] private GameObject food2;
    [SerializeField] private GameObject trigger2;
    [SerializeField] private GameObject Exit2;
    [SerializeField] private GameObject Enter2;

    [SerializeField] private GameObject food3;
    [SerializeField] private GameObject trigger3;
    [SerializeField] private GameObject Exit3;
    [SerializeField] private GameObject Enter3;

    [SerializeField] private GameObject food4;
    [SerializeField] private GameObject trigger4;
    [SerializeField] private GameObject Exit4;
    [SerializeField] private GameObject Enter4;

    [SerializeField] private GameObject food5;
    [SerializeField] private GameObject trigger5;
    [SerializeField] private GameObject Exit5;
    [SerializeField] private GameObject Enter5;

    [SerializeField] private GameObject food6;
    [SerializeField] private GameObject trigger6;
    [SerializeField] private GameObject Exit6;
    [SerializeField] private GameObject Enter6;

    [SerializeField] private GameObject food7;
    [SerializeField] private GameObject trigger7;
    [SerializeField] private GameObject Exit7;
    [SerializeField] private GameObject Enter7;


    private void Start()
    {
        _waiting = true;
        _waitTimer = 0f;
    }
    private void Update()
    {

        if (_waiting)
        {
            _waitTimer += Time.deltaTime;
            if (playerCollider.makan == 1) { 
                if (_waitTimer >= 5)
                {
                    food1.SetActive(false);
                    trigger1.SetActive(false);
                    Exit1.SetActive(false);
                    Enter1.SetActive(true);
                }
            }
            else if (playerCollider.makan == 2)
            {
                if (_waitTimer >= 5)
                {
                    food2.SetActive(false);
                    trigger2.SetActive(false);
                    Exit2.SetActive(false);
                    Enter2.SetActive(true);
                }
            }
            else if (playerCollider.makan == 3)
            {
                if (_waitTimer >= 5)
                {
                    food3.SetActive(false);
                    trigger3.SetActive(false);
                    Exit3.SetActive(false);
                    Enter3.SetActive(true);
                }
            }
            else if (playerCollider.makan == 4)
            {
                if (_waitTimer >= 5)
                {
                    food4.SetActive(false);
                    trigger4.SetActive(false);
                    Exit4.SetActive(false);
                    Enter4.SetActive(true);
                }
            }
            else if (playerCollider.makan == 5)
            {
                if (_waitTimer >= 5)
                {
                    food5.SetActive(false);
                    trigger5.SetActive(false);
                    Exit5.SetActive(false);
                    Enter5.SetActive(true);
                }
            }
            else if (playerCollider.makan == 6)
            {
                if (_waitTimer >= 5)
                {
                    food6.SetActive(false);
                    trigger6.SetActive(false);
                    Exit6.SetActive(false);
                    Enter6.SetActive(true);
                }
            }
            else if (playerCollider.makan == 7)
            {
                if (_waitTimer >= 5)
                {
                    food7.SetActive(false);
                    trigger7.SetActive(false);
                    Exit7.SetActive(false);
                    Enter7.SetActive(true);
                }
            }
        }
    }

    


}