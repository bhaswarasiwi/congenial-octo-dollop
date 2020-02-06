using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class shopBeli : MonoBehaviour {
    [SerializeField] private Text coin;
    [SerializeField] private Text daging;
    [SerializeField] private Text teh;
    [SerializeField] private Text resep;
    [SerializeField] private Text ayamgoreng;
    [SerializeField] private Text tehanget;
    [SerializeField] private GameObject sukses;
    [SerializeField] private GameObject gagal;
    [SerializeField] private GameObject navi;
    [SerializeField] private GameObject shop;
    [SerializeField] private GameObject btnShop;
    [SerializeField] private GameObject btnMasak;
    [SerializeField] private GameObject panelMasak;
    [SerializeField] private GameObject btnPesenan;
    [SerializeField] private GameObject panelPesenan;
    [SerializeField] private GameObject progress;
    [SerializeField] private GameObject progress1;
    [SerializeField] private GameObject mkn1;
    [SerializeField] private GameObject mkn2;
    [SerializeField] private GameObject mkn3;
    [SerializeField] private GameObject mkn4;
    [SerializeField] private GameObject mkn5;
    [SerializeField] private GameObject mkn6;
    [SerializeField] private GameObject mkn7;
    [SerializeField] private GameObject food1;
    [SerializeField] private GameObject food2;
    [SerializeField] private GameObject food3;
    [SerializeField] private GameObject food4;
    [SerializeField] private GameObject food5;
    [SerializeField] private GameObject food6;
    [SerializeField] private GameObject food7;
    [SerializeField] private GameObject makans;
    [SerializeField] private GameObject makans1;
    [SerializeField] private GameObject makans2;
    [SerializeField] private GameObject makans3;
    [SerializeField] private GameObject makans4;
    [SerializeField] private GameObject makans5;
    [SerializeField] private GameObject makans6;

    [SerializeField] public GameObject Objective;

    public static int memasak=0;
    public static int meminum=0;
    public static int memesan=0;

    private string jmlCoin;
    private string jmlDaging;
    private string jmlTeh;
    private string jmlResep;
    private string jmlayamgoreng;
    private string jmltehanget;
    private int Coin;
    private int Daging;
    private int Teh;
    private int Resep;
    private int Ayamgoreng;
    private int Tehanget;
    private bool _waiting;
    private bool a;
    private float _waitTimer;
    private bool _waitings;
    private bool _waitinga;
    private bool _waitingPesenan;
    private float _waitTimers;



    Animator anim;
    [SerializeField] private GameObject character;
    private GameObject unity;

    // Use this for initialization

    // Update is called once per frame
    void Start()
    {
        anim = character.GetComponent<Animator>();

        jmlCoin = coin.GetComponent<Text>().text;
        jmlDaging = daging.GetComponent<Text>().text;
        jmlTeh = teh.GetComponent<Text>().text;
        jmlResep = resep.GetComponent<Text>().text;
        jmltehanget = tehanget.GetComponent<Text>().text;
        jmlayamgoreng = ayamgoreng.GetComponent<Text>().text;

        Coin = int.Parse(jmlCoin);
        Daging = int.Parse(jmlDaging);
        Teh = int.Parse(jmlTeh);
        Resep = int.Parse(jmlResep);
        Tehanget = int.Parse(jmltehanget);
        Ayamgoreng = int.Parse(jmlayamgoreng);
        

    }
    void Update () {
        
        if (_waiting)
        {
            _waitTimer += Time.deltaTime;
            if (_waitTimer >= 1)
            {
                _waiting = false;
                sukses.SetActive(false);
                gagal.SetActive(false);
            }
        }

        if (_waitings)
        {
            _waitTimers += Time.deltaTime;
            if (_waitTimers >= 5)
            {
                if (a = true)
                {
                    shop.SetActive(true);
                    a = false;
                }
                _waitings = false;
                navi.SetActive(true);
                btnShop.GetComponent<Toggle>().enabled = true;
                AksiMasak();
                panelMasak.SetActive(false);
                btnMasak.SetActive(true);
                progress.SetActive(false);
                anim.SetTrigger("cookingEnd");
                if (Objective.activeInHierarchy)
                {
                    memasak += 1;
                }
            }
        }
        if (_waitinga)
        {
            _waitTimers += Time.deltaTime;
            if (_waitTimers >= 5)
            {
                if (a = true)
                {
                    shop.SetActive(true);
                    a = false;
                }
                _waitinga = false;
                navi.SetActive(true);
                btnShop.GetComponent<Toggle>().enabled = true;
                AksiNgombe();
                panelMasak.SetActive(false);
                btnMasak.SetActive(true);
                progress.SetActive(false);
                anim.SetTrigger("cookingEnd");
                if (Objective.activeInHierarchy)
                {
                    meminum += 1;
                }
            }
        }
        if (_waitingPesenan)
        {
            
            _waitTimers += Time.deltaTime;
            if (_waitTimers >= 2)
            {
                if (a = true)
                {
                    shop.SetActive(true);
                    a = false;
                }
                _waitingPesenan = false;
                navi.SetActive(true);
                btnShop.GetComponent<Toggle>().enabled = true;
                AksiPesenan();
                btnPesenan.SetActive(false);
                progress1.SetActive(false);
                anim.SetTrigger("cookingEnd");
                if (Objective.activeInHierarchy)
                {
                    memesan += 1;
                }
                if (playerCollider.makan == 1)
                {
                    mkn1.SetActive(false);
                    food1.SetActive(true);
                    makans.SetActive(true);
                }
                else if (playerCollider.makan == 2)
                {
                    mkn2.SetActive(false);
                    food2.SetActive(true);
                    makans1.SetActive(true);
                }else if (playerCollider.makan == 3)
                {
                    mkn3.SetActive(false);
                    food3.SetActive(true);
                    makans2.SetActive(true);
                }else if (playerCollider.makan == 4)
                {
                    mkn4.SetActive(false);
                    food4.SetActive(true);
                    makans3.SetActive(true);
                }else if (playerCollider.makan == 5)
                {
                    mkn5.SetActive(false);
                    food5.SetActive(true);
                    makans4.SetActive(true);
                }else if (playerCollider.makan == 6)
                {
                    mkn6.SetActive(false);
                    food6.SetActive(true);
                    makans5.SetActive(true);
                }else if (playerCollider.makan == 7)
                {
                    mkn7.SetActive(false);
                    food7.SetActive(true);
                    makans6.SetActive(true);
                }

            }
        }

    }
    private void Gagal()
    {
        gagal.SetActive(true);
        sukses.SetActive(false);
        _waiting = true;
        _waitTimer = 0;

    }
    private void Sukses()
    {
        sukses.SetActive(true);
        _waiting = true;
        _waitTimer = 0;

        
    }
    public void BeliDaging()
    {
        if (Coin >= 300)
        {
            Coin -= 300;
            coin.text = Coin.ToString();
            daging.text = (Daging += 10).ToString();
            Sukses();
        }
        else
        {
            Gagal();
        }
    }
    public void BeliTeh()
    {
        if (Coin >= 100)
        {
            Coin -= 100;
            coin.text = Coin.ToString();
            teh.text = (Teh += 10).ToString();
            Sukses();
        }
        else
        {
            Gagal();
        }
    }
    public void BeliResep()
    {
        if (Coin >= 50)
        {
            Coin -= 50;
            coin.text = Coin.ToString();
            resep.text = (Resep += 1).ToString();
            Sukses();
        }
        else
        {
            Gagal();
        }
    }

    public void MasakAyam()
    {
        if (Daging >= 5 && Resep >=1 )
        {
            _waitings = true;
            _waitTimers = 0f;
            navi.SetActive(false);
            btnShop.GetComponent<Toggle>().enabled=false;
            if (shop.activeInHierarchy)
            {
                shop.SetActive(false);
                a = true;
            }
            panelMasak.SetActive(false);
            btnMasak.SetActive(false);
            anim.SetTrigger("isCooking");
            progress.SetActive(true);
        }
        else
        {
            Gagal();
        }
    }

    public void Gaengombe()
    {
        if (Teh >= 5 && Resep >= 1)
        {
            _waitinga = true;
            _waitTimers = 0f;
            navi.SetActive(false);
            btnShop.GetComponent<Toggle>().enabled = false;
            if (shop.activeInHierarchy)
            {
                shop.SetActive(false);
                a = true;
            }
            panelMasak.SetActive(false);
            btnMasak.SetActive(false);
            anim.SetTrigger("isCooking");
            progress.SetActive(true);
        }
        else
        {
            Gagal();
        }
    }

    public void Pesenan()
    {
        if (Teh >= 1 && Ayamgoreng >= 1)
        {
            _waitingPesenan = true;
            _waitTimers = 0f;
            navi.SetActive(false);
            btnShop.GetComponent<Toggle>().enabled = false;
            if (shop.activeInHierarchy)
            {
                shop.SetActive(false);
                a = true;
            }
            panelPesenan.SetActive(false);
            btnPesenan.SetActive(false);
            anim.SetTrigger("isCooking");
            progress1.SetActive(true);
        }
        else
        {
            Gagal();
        }
    }

    public void AksiMasak()
    {
        Daging -= 5;
        daging.text = Daging.ToString();
        Resep -= 1;
        resep.text = Resep.ToString();
        ayamgoreng.text = (Ayamgoreng += 1).ToString();
        Sukses();
    }

    public void AksiNgombe()
    {
        Teh -= 5;
        teh.text = Teh.ToString();
        Resep -= 1;
        resep.text = Resep.ToString();
        tehanget.text = (Tehanget += 1).ToString();
        Sukses();
    }
    public void AksiPesenan()
    {
        Tehanget -= 1;
        tehanget.text = Tehanget.ToString();
        Ayamgoreng -= 1;
        ayamgoreng.text = Ayamgoreng.ToString();
        coin.text = (Coin += 100).ToString();
        Sukses();
    }
}

