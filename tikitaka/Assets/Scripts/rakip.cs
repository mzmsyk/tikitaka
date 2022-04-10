using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rakip : MonoBehaviour
{
    Transform hedefTop;
    public float rakipHiz;
    public float rakipMesafe;
    public bool kontrol = false;
    Vector2 eskiPos;
    //GameObject Oyuncu;
    void Start()
    {
        hedefTop = GameObject.FindGameObjectWithTag("top").GetComponent<Transform>();
        //Oyuncu = GameObject.FindGameObjectWithTag("oyuncu2");
        eskiPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //var dir = transform.position - hedefTop.position;
        //var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //if (kontrol == true)
        //{
            float mesafe = Vector3.Distance(transform.position, hedefTop.transform.position);
            if (mesafe < rakipMesafe)
            {
                var dir = transform.position - hedefTop.position;
                var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.position = Vector2.MoveTowards(transform.position, hedefTop.position, rakipHiz * Time.deltaTime);
                
            }
            else
            {
            //rakip ile top arasýnaki mesafe rakipmesafeden büyükse eski konuma döner
                //transform.position = Vector2.MoveTowards(transform.position, eskiPos, rakipHiz * Time.deltaTime);
            }
        //if (mesafe<1)
        //{
        //    transform.position = transform.position - Oyuncu.GetComponent<Transform>().position;
        //}
        //}
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "top")
        {
            kontrol = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
