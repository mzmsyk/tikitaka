using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okhareketi : MonoBehaviour
{
    
    public bool kontrol = false;
    GameObject Rakip;
    GameObject OyunYoneticisi;
    public bool kontrol2 = false;
    public GameObject ok;
    void Start()
    {
        Rakip = GameObject.FindGameObjectWithTag("rakip");
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
        ok.SetActive(false);
    }

    
    void Update()
    {
        if (kontrol2==true)
        {
            ok.SetActive(true);
        }
        float mesafe = Vector3.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position);
        if (kontrol==true&&OyunYoneticisi.GetComponent<oyunyoneticisi>().oyunaBaslaSure>0)
        {
            Vector2 okPoz = transform.position;
            Vector2 mousePoz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePoz - okPoz;
            transform.right = -direction*Time.deltaTime;
            
        }
        // mouse basýldýðýndaki obje ile mouse arasýndaki fark
        /*if (Mathf.Abs(mesafe)>11)
        {
            kontrol = false;
        }*/
        if (OyunYoneticisi.GetComponent<oyunyoneticisi>().oyunaBaslaSure <= 0)
        {
            // Destroy(gameObject);
            kontrol2 = false;
            //gameObject.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        kontrol = true;
        kontrol2 = true;
        if (Input.GetMouseButtonDown(0)&&kontrol)
        {
           
            
           // 444 79 88
            
        }
       
    }
    private void OnMouseUp()
    {

        kontrol = false;
    }
}
