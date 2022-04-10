using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunyoneticisi : MonoBehaviour
{
    GameObject OyuncuBir;
   
    public Transform yon1;
    public Transform yon2;
    public Transform yon3;
    public Transform yon4;
    public Transform yon5;
    public Transform yon6;
    public Transform yon7;
    public Transform yon8;
    public Transform yon9;
    GameObject OkYonu;
    GameObject OkHareketi;
    //public float okSilSure;
    public float oyunaBaslaSure;
    public Text sureText;
    public GameObject baslaPanel;
    public GameObject baslaButton;
    bool kontrol = true;
    bool kontrol2 = true;
    public float pasSayisi;
    //public float istenilenPasSayisi;
    //public float bitisSure;
    void Start()
    {
        OyuncuBir = GameObject.FindGameObjectWithTag("oyuncubir");
        OkYonu = GameObject.FindGameObjectWithTag("okyonu");
        baslaPanel.SetActive(false);
        sureText.text = oyunaBaslaSure.ToString();
        //OkHareketi=GameObject.FindGameObjectWithTag("")
    }

    
    void Update()
    {
        //Invoke("Basla", oyunBaslaSure);
        if (kontrol == true)
        {
            oyunaBaslaSure -= 1*Time.deltaTime;
            sureText.text = oyunaBaslaSure.ToString();
        }
        if (oyunaBaslaSure <= 0&&kontrol2==true)
        {
            kontrol = false;
            oyunaBaslaSure = 0;
            sureText.text = oyunaBaslaSure.ToString();
            baslaPanel.SetActive(true);
        }
        
    }
    public void Basla()
    {
        //if (oyunaBaslaSure <= 0)
        //{
        //    baslaButton.SetActive(true);
        //}
        kontrol2 = false;
        kontrol = false;
            OyuncuBir.GetComponent<birincioyuncu>().Basla();
        //baslaButton.SetActive(false);
        //OyuncuBir.GetComponent<birincioyuncu>().kontrol = true;

    }
   
}
