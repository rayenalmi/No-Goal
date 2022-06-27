using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GainSpin : MonoBehaviour
{
   
    string GS;
    public Text Tbigo;
    public Text Tstar;
    public Text Tmira;
    public Text Tcoin;
    public Text Tvie;
    public Text Tarbre;
    bool tr;
    public GameObject SPECIAL;    
    int VERT, VIOLLET, OR, BLANC, RED, BLACK;
    // Start is called before the first frame update
    void Start()
    {
        //SG = GameObject.FindWithTag("eguit");
        GS = PlayerPrefs.GetString("chspin");
        VERT = PlayerPrefs.GetInt("Tbigo");
        VIOLLET = PlayerPrefs.GetInt("Tstar");
        BLANC = PlayerPrefs.GetInt("Tmira");
        OR = PlayerPrefs.GetInt("Tcoin");
        RED = PlayerPrefs.GetInt("Tvie");
        BLACK = PlayerPrefs.GetInt("Tarbre");


    }

    string Pvie,ch,SP;


   
    public void star ()
    {
        if(VIOLLET>=5)
        {
            SP = PlayerPrefs.GetString("speciall");
            PlayerPrefs.SetString("speciall", SP + "S");
            VIOLLET-=5;
            PlayerPrefs.SetInt("Tstar", VIOLLET);
        }
    }
    public void Mira()
    {
        if (BLANC>=5)
        {
            SP = PlayerPrefs.GetString("speciall");
            PlayerPrefs.SetString("speciall", SP + "M");
            BLANC-=5;
            PlayerPrefs.SetInt("Tmira", BLANC);

        }
    }
    public void Bigo()
    {
        if (VERT >=5)
        {
            SP = PlayerPrefs.GetString("speciall");
            PlayerPrefs.SetString("speciall", SP + "B");
            VERT-=5;
            PlayerPrefs.SetInt("Tbigo", VERT);
        }
    }

    public void Vie()
    {
      
        if (RED>=1)
        {
            ch ="❤️"; 
            Pvie = ch;
            PlayerPrefs.SetString("Pvie", Pvie);
            RED -= 1;
            PlayerPrefs.SetInt("Tvie", RED);
        }
    }


    // Update is called once per frame
    void Update()
    {

       
  
        Tbigo.text = VERT.ToString();
        Tstar.text = VIOLLET.ToString();
        Tmira.text = BLANC.ToString();
        Tcoin.text = OR.ToString();
        Tvie.text  = RED.ToString();
        Tarbre.text= BLACK.ToString();
      
    }
}
