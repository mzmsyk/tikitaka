using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oksil : MonoBehaviour
{
    GameObject OyunYoneticisi;
    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
    }

    // Update is called once per frame
    void Update()
    {
        if (OyunYoneticisi.GetComponent<oyunyoneticisi>().oyunaBaslaSure <= 0)
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
        
}
