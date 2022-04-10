using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birincioyuncu : MonoBehaviour
{
    public Transform yon;
    public GameObject top;
    GameObject Top;
    GameObject Rakip;
    float olusturmaSayac = 0;
    public bool kontrol = false;
    public bool kontrol2 = false;
    public float topHiz;
    GameObject OyunYoneticisi;
    void Start()
    {
        Top = GameObject.FindGameObjectWithTag("top");
        Rakip = GameObject.FindGameObjectWithTag("rakip");
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
    }

    private void FixedUpdate()
    {
        //if (kontrol2==true)
        //{
           // top.GetComponent<top>().fizik.velocity = transform.right * 5;
        //}
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&kontrol==true)
        {
            //kontrol2 = true;
            olusturmaSayac++;
            if (olusturmaSayac == 1)
            {
                //Rakip.GetComponent<rakip>().enabled = true;
                //Instantiate(top, yon.position, yon.rotation);
                top.SetActive(true);
                //top.GetComponent<top>().hiz = topHiz;
                
            }
            
        }
    }
    public void Basla()
    {
        top.GetComponent<top>().hiz = topHiz;
        OyunYoneticisi.GetComponent<oyunyoneticisi>().baslaButton.SetActive(false);
    }
}
