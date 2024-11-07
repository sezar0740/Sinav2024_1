using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: berke kocaaslan
    // Öğrenci Numarası: 222011015


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
    private Rigidbody2D karakterRb;

    public float hiz = 5f;
    public float ziplamaGucu = 5f;

    public int skor = 0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yazdığınız metodları çağırınız.
        HareketEt();
        Zipla();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Soru 3 ve soru 4 burada çözülecek.
        if (other.CompareTag("Engel"))
        {
            metin.text = "oyun bitti";
        }
        if (other.CompareTag("Puan"))
        {
            skor++;
            metin.text = "Skor: " + skor;  
        }
    }
    void HareketEt()
    {
        // Yön tuşları ile karakteri hareket ettirme
        float yatayInput = Input.GetAxis("Horizontal");
        Vector2 hareket = new Vector2(yatayInput * hiz); 
    }
        void Zipla()
        {
            // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.
            if (Input.GetKeyDown(KeyCode.Space))
            {   
                Vector3 ziplamaYonu = new Vector3(0,1);
                karakterRb.AddForce(ziplamaYonu * (Vector3.up * ziplamaGucu, ForceMode2D.Impulse);
            }
        }
}