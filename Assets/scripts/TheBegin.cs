using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TheBegin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Helpp;
    public GameObject HSCORE;
    public GameObject SC;
    public Text Score;
    public Text EXP;
    public Text LVL;
    public Text rare;
    //  public string Tscore;
   
    bool tr=false;
    int  HI,j,exp,lvl;
    int[] tLVL = { 50, 100, 175, 250, 300, 400, 550, 700, 850,1000,1150,1350,1550,1700,1900,2200 };
    public void HELP()
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

    public void shop()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;

    }
    public void STARTT()
    {
        PlayerPrefs.SetString("vie", "❤️❤️❤️❤️");
        PlayerPrefs.SetString("score", "0");
        PlayerPrefs.SetInt("pausedeth", 0);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }


    void OnApplicationQuit()
    {
        SceneManager.LoadScene(0);
    }


        public void exit()
    {
        SceneManager.LoadScene(0);
        Application.Quit();
    }


    void Start()
    {

       

        if (PlayerPrefs.GetInt("SI") < PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("SI", PlayerPrefs.GetInt("score"));
        }
      

       
       
        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + PlayerPrefs.GetInt("score") );
    
        PlayerPrefs.SetString("score", "0");


        EXP.text = PlayerPrefs.GetInt("exp").ToString();


       
        //  lvl = PlayerPrefs.GetInt("lvl");
        rare.text = PlayerPrefs.GetInt("rare").ToString();
        LVL.text = PlayerPrefs.GetInt("lvl").ToString();
        Score.text = PlayerPrefs.GetInt("SI").ToString();
    }

  /*
   *
   * void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }



    */
    // Update is called once per frame
    void Update()
    {

      

        /* RBG.r = 0f;
         RBG.b = 0f;
         RBG.a = 0f; */


        /*Tscore = PlayerPrefs.GetString("Hsc");
        Debug.Log(PlayerPrefs.GetString("Hsc"));
        Tscore = Score.text;
        PlayerPrefs.GetString("Score", Tscore);*/
        if (tr==true )
        {
            Helpp.SetActive(false);
            HSCORE.SetActive(true);
            SC.SetActive(true);
        }
        else
        {
            Helpp.SetActive(true);
            HSCORE.SetActive(false);
            SC.SetActive(false);
        }
     
    }
}






















