using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class slider : MonoBehaviour
{


    public Text lvl;
    public Text rare;
    public Text max;
    int[] tLVL = { 50, 100, 175, 250, 300, 400, 550, 700, 850, 1000, 1150, 1350, 1550, 1700, 1900, 2200 };
    int nb,i,x,lvlA;
    // Start is called before the first frame update


        void Awake()
    {
        Fmax(PlayerPrefs.GetInt("lvl"), tLVL);
        if ((PlayerPrefs.GetInt("maxslider")) == 0)
        {
            PlayerPrefs.SetInt("maxslider", tLVL[0]);
            this.GetComponent<Slider>().maxValue = PlayerPrefs.GetInt("maxslider");
        }


        this.GetComponent<Slider>().value = PlayerPrefs.GetInt("exp");
    }


    void Start()
    {
    
        

    }




        void Fmax(int a, int[] b)
    {
      int  s = 0;
        for (i=0;i<=a;i++)
        {
            s += b[i]; 
        }
        
        PlayerPrefs.SetInt("maxslider", s);
    }



   

    void GainLvl()
    {
        PlayerPrefs.SetInt("Tbigo", PlayerPrefs.GetInt("Tbigo") + 10);
        PlayerPrefs.SetInt("Tmira", PlayerPrefs.GetInt("Tmira") + 10);
        PlayerPrefs.SetInt("Tstar", PlayerPrefs.GetInt("Tstar") + 10);
        PlayerPrefs.SetInt("rare", PlayerPrefs.GetInt("rare") + 1);
        PlayerPrefs.SetInt("Tcoin", PlayerPrefs.GetInt("Tcoin") + 10);
        PlayerPrefs.SetInt("Tarbre", PlayerPrefs.GetInt("Tarbre") + 10);
        PlayerPrefs.SetInt("Tvie", PlayerPrefs.GetInt("Tvie") + 3);

       


    }

    void Update()
    {



        this.GetComponent<Slider>().value = PlayerPrefs.GetInt("exp");

        max.text = PlayerPrefs.GetInt("maxslider").ToString();
        rare.text = PlayerPrefs.GetInt("rare").ToString();
        lvl.text = PlayerPrefs.GetInt("lvl").ToString();


        
     
        if  (this.GetComponent<Slider>().value == this.GetComponent<Slider>().maxValue) 
        {
            Fmax(PlayerPrefs.GetInt("lvl"), tLVL);
            this.GetComponent<Slider>().maxValue = PlayerPrefs.GetInt("maxslider");


            if (this.GetComponent<Slider>().value == this.GetComponent<Slider>().maxValue)
            {
                PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + 1);

                Fmax(PlayerPrefs.GetInt("lvl"), tLVL);
                this.GetComponent<Slider>().minValue = this.GetComponent<Slider>().maxValue;
                this.GetComponent<Slider>().maxValue = PlayerPrefs.GetInt("maxslider");


                GainLvl();

            }



        }
       
    }
}

























