using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CHARspacial : MonoBehaviour
{
    public Text NbMira;
    public Text NbBigo;
    public Text NbStar;
    public GameObject bigo;
    public GameObject mira;
    public GameObject star;
    GameObject cage;
    public GameObject spider;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("baseM", 2.2f);
        PlayerPrefs.SetFloat("baseB", 2.2f);
        PlayerPrefs.SetFloat("baseS", 2.2f);
        cage=GameObject.FindGameObjectWithTag("cage");
    }
    string ch;
    int b,m,s;
    bool tr=false;

    public void special()
    {
        if (tr == false)
        {
            tr = true;
        }
        else
        {
            tr = false;
        }
    }

    // Update is called once per frame

        public void Bstar()
    {
        if(PlayerPrefs.GetInt("s")!=0)
        {
            PlayerPrefs.SetFloat("TimeS", PlayerPrefs.GetFloat("baseS")+PlayerPrefs.GetFloat("TimeAddS") +2);
            PlayerPrefs.SetInt("trs", 1);
            PlayerPrefs.SetInt("s", PlayerPrefs.GetInt("s") - 1);
            
        }
    }

    public void Bbigo()
    {

        if(PlayerPrefs.GetInt("b")!=0)
        {
            PlayerPrefs.SetFloat("TimeB", PlayerPrefs.GetFloat("TimeAddB") + PlayerPrefs.GetFloat("baseB") +2);
            PlayerPrefs.SetInt("trb", 1);
            PlayerPrefs.SetInt("b", PlayerPrefs.GetInt("b") - 1);
         
        }

    }


    public void Bmira()
    {
        if(PlayerPrefs.GetInt("m")!=0)
        {

            PlayerPrefs.SetFloat("TimeM", PlayerPrefs.GetFloat("TimeAddM") + PlayerPrefs.GetFloat("baseM") +2);
            PlayerPrefs.SetInt("trm", 1);
            PlayerPrefs.SetInt("m", PlayerPrefs.GetInt("m") - 1);
        }
    }



    void Update()
    {


        PlayerPrefs.SetFloat("positioncage", cage.transform.position.x); 




        if (PlayerPrefs.GetInt("trm")==1)
        {
            spider.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("trb") == 1)
        {
            spider.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("trs") == 1)
        {
            spider.SetActive(true);
        }
        else
        {
            spider.SetActive(false);
        }


        if (PlayerPrefs.GetString("speciall").Length!=0)
        {
            ch = PlayerPrefs.GetString("speciall");
           
            if (ch.Substring(0, 1)=="B")
            {
                b++;
                ch = ch.Remove(0, 1);
                PlayerPrefs.SetString("speciall", ch);
                PlayerPrefs.SetInt("b", b);


            }
            else
            if (ch.Substring(0, 1) == "M")
            {
                m++;
                ch = ch.Remove(0, 1);
                PlayerPrefs.SetString("speciall", ch);
                PlayerPrefs.SetInt("m", m);


            }
            else
            if (ch.Substring(0, 1) == "S")
            {
                s++;
                ch = ch.Remove(0, 1);
                PlayerPrefs.SetString("speciall", ch);
                PlayerPrefs.SetInt("s", s);


            }

        }





        NbBigo.text = PlayerPrefs.GetInt("b").ToString();
        NbMira.text = PlayerPrefs.GetInt("m").ToString();
        NbStar.text = PlayerPrefs.GetInt("s").ToString();




  

       

       

        


      if(tr==true)
        {
            mira.SetActive(true);
            bigo.SetActive(true);
            star.SetActive(true);
        }
      else 
        {
            mira.SetActive(false);
            bigo.SetActive(false);
            star.SetActive(false);
        }

    }
    string MS;
   
}
