using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Awake()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("pausedeth") != 1)
        {
            transform.Translate(0, 0.03f, 0);
        }
    }
}
