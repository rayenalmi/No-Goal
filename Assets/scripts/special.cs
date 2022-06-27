using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class special : MonoBehaviour
{

  
    public string ch1 = "";

    // Start is called before the first frame update
    void Awake()
    {

      //  DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "vide")
        {
            ch1 = "aaaa";
         //   Debug.Log(ch1);
        }
     
        if (col.gameObject.name == "vert")
        {
            ch1 = col.gameObject.name;
          //  Debug.Log(ch1);
        }

        if (col.gameObject.name == "marron")
        {
            ch1 = col.gameObject.name;
         //   Debug.Log(ch1);
        }

        if (col.gameObject.name == "viollet")
        {
            ch1 = col.gameObject.name;
          //  Debug.Log(ch1);
        }

        if (col.gameObject.name == "blanc")
        {
            ch1 = col.gameObject.name;
         //   Debug.Log(ch1);
        }

        if (col.gameObject.name == "rouge")
        {
            ch1 = col.gameObject.name;
          //  Debug.Log(ch1);
        }
        PlayerPrefs.SetString("chspin", ch1);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
