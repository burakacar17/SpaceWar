using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody unity traf�ndan haz�rlanan fizik kurallar�n� game objemize uygalamam�z� sa�layan bir haz�r scriptir.
        //Bir objeyi hareket ettirmek i�in Kuvvete ihityac�m�z var ve bu kuvvetleri bu rigidbody scriptinden kendi scriptimize bir
        //referans alarak kuvvet ekliyoruz.Kuvvet modunu impulse se�memizin sebebi ise objemizi vektorel olarak hareket etitrmeye yarar.

        GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
        
    }

    //�arp���nca ne olaca��n� girid�imiz method
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kemerlerinizi Ba�lay�n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
