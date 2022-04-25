using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody unity trafýndan hazýrlanan fizik kurallarýný game objemize uygalamamýzý saðlayan bir hazýr scriptir.
        //Bir objeyi hareket ettirmek için Kuvvete ihityacýmýz var ve bu kuvvetleri bu rigidbody scriptinden kendi scriptimize bir
        //referans alarak kuvvet ekliyoruz.Kuvvet modunu impulse seçmemizin sebebi ise objemizi vektorel olarak hareket etitrmeye yarar.

        GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
        
    }

    //Çarpýþýnca ne olacaðýný giridðimiz method
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kemerlerinizi Baðlayýn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
