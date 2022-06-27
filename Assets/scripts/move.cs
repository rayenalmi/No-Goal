using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    public GameObject REP;
    public GameObject tab;
    public GameObject befordeth;
   // public GameObject BeforDeth;
    public Text TBD ;
    public Text Trare;
    bool tr ,tr1;
    public GameObject AllerSpin;
    public GameObject NoSpin;
    string ch,Hsc;
    string speciial;
    public Text score;
    public Text vie;
    int k = 0, HscINT;
    float f,ff,x,kk;
    public GameObject pauseE;
    public GameObject NotPause;
    private int i;
    GameObject droite;
    GameObject gauche;
    float tiemfordeth=5.6f;
    int F;

   

    private void Awake()
    {
        
        if (Caching.ClearCache())
        {
           // Debug.Log("Successfully cleaned the cache.");
        }
        else
        {
            //Debug.Log("Cache is being used.");
        }

    }

    public void Restart()
    {
        PlayerPrefs.SetString("vie", "❤️❤️❤️❤️");
        PlayerPrefs.SetString("score", "0");
        PlayerPrefs.SetInt("pausedeth", 0);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

     public void replay ()
    {
       
        SceneManager.LoadScene(0);
        
    }

   public void closebox ()
    {
        tab.SetActive(false);
        Time.timeScale = 1;
        NotPause.SetActive(false);
        pauseE.SetActive(true);
        REP.SetActive(false);
    }
    public void box()
    {
        Time.timeScale = 0;
        tab.SetActive(true);
        pauseE.SetActive(false);
        NotPause.SetActive(true);
    }

   
    public void continuer()
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") - 1);
        NoSpin.SetActive(false);
        Time.timeScale = 1;

    }

    public void pause ()
    {
        pauseE.SetActive(false);
        NotPause.SetActive(true);
        REP.SetActive(true);
        Time.timeScale = 0;
    }                               
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "bal")
        {
           
            k++;
            PlayerPrefs.SetInt("score", k);
        }
    }
  
    public void Aller()
    {
        NoSpin.SetActive(true);
        AllerSpin.SetActive(false);
        PlayerPrefs.SetInt("maxspin", 0);
        NoSpin.SetActive(true);
        SceneManager.LoadScene(2);

    }
    void OnCollisionEnter2D(Collision2D cc)
    {

        if (cc.gameObject.tag == "bal")
        {

            
        //    ch = ch.Substring(0, ch.Length - 2);
            PlayerPrefs.SetString("vie", PlayerPrefs.GetString("vie").Substring(0, PlayerPrefs.GetString("vie").Length - 2));
            vie.text = ch;
            
        }
       
    }

    
    // Start is called before the first frame update
    void Start()
    {


        droite = GameObject.FindGameObjectWithTag("right");
        gauche = GameObject.FindGameObjectWithTag("left");
       // HscINT = PlayerPrefs.GetInt("SI");
      
        k = PlayerPrefs.GetInt("score");

        if (k == 0)
        {
          //  ch = "❤️❤️❤️❤️";
            PlayerPrefs.SetString("vie", "❤️❤️❤️❤️");
        }
        else
        {  
            ch = PlayerPrefs.GetString("vie");
        }

        if(k==0)
        {
            kk = 0;
            PlayerPrefs.SetFloat("kk", kk);
        }


      //  this.GetComponent<SpriteRenderer>().sprite = mySprite;
      

    }



    void Update()
    {

      


       
       



     /*  string Pvie = PlayerPrefs.GetString("Pvie");
            ch += Pvie;
            Pvie = "";
            PlayerPrefs.SetString("Pvie", Pvie);
        */

    }


    public void beforDeth()
    {
        if (PlayerPrefs.GetInt("rare") > 0)
        {
          
            // ch = "❤️❤️";
             PlayerPrefs.SetInt("pausedeth", 0);
            PlayerPrefs.SetString("vie", "❤️❤️");
            befordeth.SetActive(false);
            // BeforDeth.SetActive(false);
            //   Trare.text = PlayerPrefs.GetInt("rare").ToString();
            PlayerPrefs.SetInt("rare", PlayerPrefs.GetInt("rare") - 1);
           
        }
    }


    public void Notpausee()
        {
        Time.timeScale = 1;
        REP.SetActive(false);
        tr = false;

        tab.SetActive(false);
        NotPause.SetActive(false);
        pauseE.SetActive(true);
        REP.SetActive(false);

    }

    /* void OnApplicationQuit()
      {
          PlayerPrefs.DeleteAll();
      }
      */

    void OnApplicationQuit()
    {
        SceneManager.LoadScene(0);
    }


    public void Vie()
    {

    }
    // Update is called once per frame
    void FixedUpdate()      

    {
       
        if (droite.GetComponent<right>().buttonPressedright==true)
        {
            x = 1;
        }
        else if(gauche.GetComponent<left>().buttonPressedleft==true)
        {
            x = -1;
        }
        else
        {
            x = 0;
        }

        

        if (PlayerPrefs.GetInt("pausedeth") != 1)
        {
            transform.Translate(0, 0.03f, 0);
            transform.Translate(Input.GetAxis("Horizontal") * 0.065f, 0, 0);
        }
     
        if (PlayerPrefs.GetInt("pausedeth") != 1)
        {
            transform.Translate(0.065f * x, 0, 0);
        }

        Trare.text = PlayerPrefs.GetInt("rare").ToString();

        score.text = k.ToString( );
        vie.text = PlayerPrefs.GetString("vie") ;

        if (PlayerPrefs.GetString("vie").Length == 0)
        {
           
           
          //  PlayerPrefs.SetInt("Hscretour", k);
         
            befordeth.SetActive(true);
            PlayerPrefs.SetInt("pausedeth", 1);
            tiemfordeth -= Time.deltaTime;
            TBD.text = Math.Truncate(tiemfordeth).ToString();




        }
        else
        {
            PlayerPrefs.SetInt("pausedeth",0);
        }





      if(tiemfordeth<-0.1)
        {

            befordeth.SetActive(false);
            REP.SetActive(true);
            PlayerPrefs.SetInt("pausedeth", 0);
            Time.timeScale = 0;
        }

      // les 200 preimer point
        if ((k % 80 == 0) &&(k!=0)&& (k < 260)) 
        {
            PlayerPrefs.SetInt("maxspin", 1);
            Time.timeScale = 0;
        }


          


        // a partir de 200 vert 500 


        if ((k % 150 == 0) && (k>300)&&(k<500))
        {
            PlayerPrefs.SetInt("maxspin", 1);
            Time.timeScale = 0;
        }

        // agme,ter la vitesse de jeu

        if ((k % 20 == 0) && (k < 200))
        {

            PlayerPrefs.SetFloat("kk", PlayerPrefs.GetFloat("kk") + 0.0005f);


        }

        if ((k % 40 == 0)  && (k > 300)&&( k<600 ))
        {

            PlayerPrefs.SetFloat("kk", PlayerPrefs.GetFloat("kk") + 0.00009f);

        }

        if((k % 60 == 0) &&( k>700 ))
        {
            PlayerPrefs.SetFloat("kk", PlayerPrefs.GetFloat("kk") + 0.0009f);
        }
        // vitesse terminer

        if (PlayerPrefs.GetInt("maxspin") ==1)
        {
            AllerSpin.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("maxspin") == 0)
        {
            Time.timeScale = 0;
            AllerSpin.SetActive(false);
            NoSpin.SetActive(true);
            PlayerPrefs.SetInt("maxspin", 2);
        }

        if (tr==true)
        {
            
            pauseE.SetActive(false);
            NotPause.SetActive(true);
            Time.timeScale = 0;
        }
       if (tr==false)
        {
           
            NotPause.SetActive(false);
            pauseE.SetActive(true);
        }


    }
}
