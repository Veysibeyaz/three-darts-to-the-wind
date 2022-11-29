using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iliski : MonoBehaviour
{
    public int hasar;
    private Rigidbody rb1;
    private bool vuruldumu;

    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (vuruldumu)
        {
            return;
        }
        else
        {
            vuruldumu = true;
        }

        if(collision.gameObject.GetComponent<tahtayikaldir>() != null)
        {
            tahtayikaldir tahta = collision.gameObject.GetComponent<tahtayikaldir>();
            tahta.HasarVer(hasar);
            Destroy(gameObject);
        }

        rb1.isKinematic = true;
        transform.SetParent(collision.transform);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
