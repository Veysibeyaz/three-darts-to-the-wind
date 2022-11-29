using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tahtayikaldir : MonoBehaviour
{

    public int kalanatis;

    public void HasarVer(int hasar)
    {
        kalanatis -= hasar;

        if (kalanatis <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
