using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondur : MonoBehaviour
{

    Time Time = new Time();
    [SerializeField] private float _move = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, _move * Time.deltaTime);
    }

}
