using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class dur : MonoBehaviour
{
    public static bool oyundur = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (oyundur)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        Time.timeScale = 1f;
        oyundur = false;
    }

    void Pause()
    {
        Time.timeScale = 0f;
        oyundur = true;
    }
}
