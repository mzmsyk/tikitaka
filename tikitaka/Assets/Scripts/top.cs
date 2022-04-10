using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class top : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    GameObject OyunYoneticisi;
    bool kontrol0 = false;
    bool kontrol1 = false;
    bool kontrol2 = false;
    bool kontrol3= false;
    bool kontrol4 = false;
    bool kontrol5 = false;
    bool kontrol6 = false;
    bool kontrol7 = false;
    bool kontrol8 = false;
    bool kontrol9 = false;
    
    GameObject OkYonu;
    GameObject BirinciOyuncu;
    public static float pasSayisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
        OkYonu = GameObject.FindGameObjectWithTag("okyonu");
        BirinciOyuncu = GameObject.FindGameObjectWithTag("oyuncubir");
        pasSayisi = OyunYoneticisi.GetComponent<oyunyoneticisi>().pasSayisi;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        fizik.velocity =transform.right * hiz * Time.fixedDeltaTime;
        //fizik.velocity = new Vector2(BirinciOyuncu.GetComponent<birincioyuncu>().yon.forward.x * hiz * Time.fixedDeltaTime, BirinciOyuncu.GetComponent<birincioyuncu>().yon.forward.y * hiz * Time.fixedDeltaTime);

        //fizik.velocity = -OkYonu.GetComponent<okyonu>().okYonu.right * hiz * Time.fixedDeltaTime;
        //fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon1.position.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon1.position.y * hiz * Time.fixedDeltaTime);
        
        if (kontrol1 == true)
        {
            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon1.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon1.right.y * hiz * Time.fixedDeltaTime);
            //fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol2 == true)
        {
            
            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol3 == true)
        {

            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon3.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon3.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol4 == true)
        {
            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon4.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon4.right.y * hiz * Time.fixedDeltaTime);
            //fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol5 == true)
        {

            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon5.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon5.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol6 == true)
        {

            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon6.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon6.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol7 == true)
        {
            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon7.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon7.right.y * hiz * Time.fixedDeltaTime);
            //fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol8 == true)
        {

            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon8.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon8.right.y * hiz * Time.fixedDeltaTime);
        }
        if (kontrol9 == true)
        {

            fizik.velocity = new Vector2(OyunYoneticisi.GetComponent<oyunyoneticisi>().yon9.right.x * hiz * Time.fixedDeltaTime, OyunYoneticisi.GetComponent<oyunyoneticisi>().yon9.right.y * hiz * Time.fixedDeltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "kale")
        {
            Debug.Log("oyun bitti..");
            if (pasSayisi == 0)
            {
                //pasSayisi = 0;
                SceneManager.LoadScene("2");
                Debug.Log(pasSayisi);
            }
        }
        if (col.gameObject.tag == "sinir")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (col.gameObject.tag == "oyuncu2")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = true;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;
            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon1.position;
            
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu3")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = true;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;
            
            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon2.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu4")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = true;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon3.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu5")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = true;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon4.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu6")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = true;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon5.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu7")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = true;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon6.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu8")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = true;
            kontrol8 = false;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon7.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu9")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = true;
            kontrol9 = false;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon8.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
        if (col.gameObject.tag == "oyuncu10")
        {
            pasSayisi--;
            BirinciOyuncu.GetComponent<birincioyuncu>().kontrol2 = false;
            kontrol0 = false;
            kontrol1 = false;
            kontrol2 = false;
            kontrol3 = false;
            kontrol4 = false;
            kontrol5 = false;
            kontrol6 = false;
            kontrol7 = false;
            kontrol8 = false;
            kontrol9 = true;
            fizik.velocity = Vector2.zero;

            transform.position = OyunYoneticisi.GetComponent<oyunyoneticisi>().yon9.position;
            //transform.position=OkYonu.GetComponent<okyonu>().okYonu.position;

        }
       


    }
    
    
}
