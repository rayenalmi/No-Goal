using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;


public class ReturnColor : MonoBehaviour
{

    GameObject R;
    GameObject B;
    GameObject G;
    GameObject T;
    public Color RBG;

    
    // Start is called before the first frame update
    void Start()
    {
     R = GameObject.FindGameObjectWithTag("RED");
     B = GameObject.FindGameObjectWithTag("BLEU");
     G = GameObject.FindGameObjectWithTag("GREEN");
     T = GameObject.FindGameObjectWithTag("TR");

    this.GetComponent<Image>().color = Color.black;
        
    }
    

    // Update is called once per frame
    void Update()
    {
         RBG.r = R.GetComponent<Slider>().value;
         RBG.g = G.GetComponent<Slider>().value; 
         RBG.b = B.GetComponent<Slider>().value; 
         RBG.a = T.GetComponent<Slider>().value;  

        // RBG.r = R.GetComponent<slider>().value;

        this.GetComponent<Image>().color = RBG;


    }
}
