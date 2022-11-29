using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vur : MonoBehaviour
{

    [Header("Kaynak")] public Transform cam;
    [Header("Kaynak")] public Transform vurusyeri;
    [Header("Kaynak")] public GameObject nesne;

    [Header("Degisken")] public int toplamatis;
    [Header("Degýsken")] public float beklemesuresi;

    [Header("Atýs")] public float kuvvet;
    [Header("Atýs")] public float yukarikuvvet;
    [Header("Atýs")] public float yatayHiz, dikeyHiz;


    bool hazirmi;

    // Start is called before the first frame update
    void Start()
    {
        hazirmi = true;
    }

    // Update is called once per frame
    void Update()
    {
        float yataykontrol = Input.GetAxis("Mouse X") * yatayHiz;
        float dikeykontrol = Input.GetAxis("Mouse Y") * dikeyHiz;
        transform.Translate(yataykontrol * Time.deltaTime, dikeykontrol * Time.deltaTime, 0f);

        if (Input.GetAxis("Jump") > 0 && hazirmi && toplamatis > 0)
        {

            At();
        }
    }

    private void At()
    {
        hazirmi = false;
        GameObject d = Instantiate(nesne, vurusyeri.position, cam.rotation);
        Rigidbody rb = d.GetComponent<Rigidbody>();
        Vector3 kuvvetyonu = cam.transform.forward;
        RaycastHit l;

        if (Physics.Raycast(cam.position, cam.forward, out l, 500f))
        {
            kuvvetyonu = (l.point - vurusyeri.position).normalized;
        }


        Vector3 ekle = kuvvetyonu * kuvvet + transform.up * yukarikuvvet;

        rb.AddForce(ekle, ForceMode.Impulse);

        toplamatis--;

        Invoke(nameof(At1), beklemesuresi);

        
    }

    private void At1()
    {
        hazirmi = true;
    }
}
