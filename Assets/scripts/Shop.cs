using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    public GameObject bigo;
    public GameObject mira;
    public GameObject star;
    public Text textCoin;
    public Text textArbre;
    public Text textmira;
    public Text textbigo;
    public Text textstar;
    public Text textrare;
    public Text ObligeMiraM;
    public Text ObligeMiraC;
    public Text ObligeMiraR;
    public Text ObligeMiraA;
    public Text ObligeBigoB;
    public Text ObligeBigoA;
    public Text ObligeBigoC;
    public Text ObligeBigoR;
    public Text ObligeStarC;
    public Text ObligeStarR;
    public Text ObligeStarA;
    public Text ObligeStarS;

    public GameObject ADD;
    public GameObject PLAYER;
    bool tr = false;

    public GameObject AllAdd;
    public GameObject ALLPlayer;
    public GameObject AllMap;

    string chshop;
    int x;
    void Awake()
    {
    if(PlayerPrefs.GetInt("ObligeBigoR")!=0)
        {
            ObligeBigoR.text = PlayerPrefs.GetInt("ObligeBigoR").ToString();
        }

    if(PlayerPrefs.GetInt("ObligeBigoA")!=0)
        {
            ObligeBigoA.text = PlayerPrefs.GetInt("ObligeBigoA").ToString();
        }
    if(PlayerPrefs.GetInt("ObligeBigoC")!=0)
        {
            ObligeBigoC.text = PlayerPrefs.GetInt("ObligeBigoC").ToString();
        }
    if(PlayerPrefs.GetInt("ObligeBigoB")!=0)
        {
            ObligeBigoB.text = PlayerPrefs.GetInt("ObligeBigoB").ToString();
        }


    if(PlayerPrefs.GetInt("ObligeStarC")!=0)
        {
            ObligeStarC.text = PlayerPrefs.GetInt("ObligeStarC").ToString();
        }

        if (PlayerPrefs.GetInt("ObligeStarA") != 0)
        {
            ObligeStarA.text = PlayerPrefs.GetInt("ObligeStarA").ToString();
        }

        if (PlayerPrefs.GetInt("ObligeStarR") != 0)
        {
            ObligeStarR.text = PlayerPrefs.GetInt("ObligeStarR").ToString();
        }

        if (PlayerPrefs.GetInt("ObligeStarS") != 0)
        {
            ObligeStarS.text = PlayerPrefs.GetInt("ObligeStarS").ToString();
        }





        if (PlayerPrefs.GetInt("ObligeMiraR") != 0)
        {
            ObligeMiraR.text = PlayerPrefs.GetInt("ObligeMiraR").ToString();
        }

        if (PlayerPrefs.GetInt("ObligeMiraA") != 0)
        {
            ObligeMiraA.text = PlayerPrefs.GetInt("ObligeMiraA").ToString();
        }
        if (PlayerPrefs.GetInt("ObligeMiraC") != 0)
        {
            ObligeMiraC.text = PlayerPrefs.GetInt("ObligeMiraC").ToString();
        }
        if (PlayerPrefs.GetInt("ObligeMiraM") != 0)
        {
            ObligeMiraM.text = PlayerPrefs.GetInt("ObligeMiraB").ToString();
        }

        





       
        textCoin.text = PlayerPrefs.GetInt("Tcoin").ToString();
        textArbre.text = PlayerPrefs.GetInt("Tarbre").ToString();
        textmira.text = PlayerPrefs.GetInt("Tmira").ToString();
        textbigo.text = PlayerPrefs.GetInt("Tbigo").ToString();
        textstar.text = PlayerPrefs.GetInt("Tstar").ToString();
        textrare.text = PlayerPrefs.GetInt("rare").ToString();


    }

    // Start is called before the first frame update

    /*
     32.87 depart 
     190 fin

    distanse 157.13
    */
    
    void Start()
    {
      if(PlayerPrefs.GetFloat("BigoSlidermove")!=0)
        {
            bigo.transform.position = new Vector3(PlayerPrefs.GetFloat("BigoSlidermove"),bigo.transform.position.y, 0);
        }
      if(PlayerPrefs.GetFloat("MiraSlidermove")!=0)
        {
          mira.transform.position =new Vector3 ( PlayerPrefs.GetFloat("MiraSlidermove"),mira.transform.position.y,0);
        }

    }
   public void Player()
    {

        chshop = "player";


    }

    public void Add()
    {
        chshop = "add";
    }

    public void Map()
    {
        chshop = "map";
    }


        int VerifierAdditionM(int a,int b, int c , int d)
    {
       
        if ((PlayerPrefs.GetInt("Tmira")>=a)&(PlayerPrefs.GetInt("Tcoin")>=b)&(PlayerPrefs.GetInt("Tarbre")>=c)&(PlayerPrefs.GetInt("rare"))>=d)
            {
            PlayerPrefs.SetInt("Tmira", PlayerPrefs.GetInt("Tmira") - a);
            PlayerPrefs.SetInt("Tcoin", PlayerPrefs.GetInt("Tcoin") - b);
            PlayerPrefs.SetInt("Tarbre", PlayerPrefs.GetInt("Tarbre") - c);
            PlayerPrefs.SetInt("rare", PlayerPrefs.GetInt("rare") - d);

            textCoin.text = PlayerPrefs.GetInt("Tcoin").ToString();
            textArbre.text = PlayerPrefs.GetInt("Tarbre").ToString();
            textmira.text = PlayerPrefs.GetInt("Tmira").ToString();
            textbigo.text = PlayerPrefs.GetInt("Tbigo").ToString();
            textstar.text = PlayerPrefs.GetInt("Tstar").ToString();
            textrare.text = PlayerPrefs.GetInt("rare").ToString();




            x = 1;
            }
        return x;
    }

    int VerifierAdditionS(int a, int b, int c, int d)
    {

        if ((PlayerPrefs.GetInt("Tstar") >= a) & (PlayerPrefs.GetInt("Tcoin") >= b) & (PlayerPrefs.GetInt("Tarbre") >= c) & (PlayerPrefs.GetInt("rare")) >= d)
        {
            PlayerPrefs.SetInt("Tstar", PlayerPrefs.GetInt("Tstar") - a);
            PlayerPrefs.SetInt("Tcoin", PlayerPrefs.GetInt("Tcoin") - b);
            PlayerPrefs.SetInt("Tarbre", PlayerPrefs.GetInt("Tarbre") - c);
            PlayerPrefs.SetInt("rare", PlayerPrefs.GetInt("rare") - d);


            textCoin.text = PlayerPrefs.GetInt("Tcoin").ToString();
            textArbre.text = PlayerPrefs.GetInt("Tarbre").ToString();
            textmira.text = PlayerPrefs.GetInt("Tmira").ToString();
            textbigo.text = PlayerPrefs.GetInt("Tbigo").ToString();
            textstar.text = PlayerPrefs.GetInt("Tstar").ToString();
            textrare.text = PlayerPrefs.GetInt("rare").ToString();



            x = 1;
        }
            return x;
        }


        int VerifierAdditionB(int a, int b, int c, int d)
    {

        if ((PlayerPrefs.GetInt("Tbigo") >= a) & (PlayerPrefs.GetInt("Tcoin") >= b) & (PlayerPrefs.GetInt("Tarbre") >= c) & (PlayerPrefs.GetInt("rare")) >= d)
        {
            PlayerPrefs.SetInt("Tbigo", PlayerPrefs.GetInt("Tbigo")-a);
            PlayerPrefs.SetInt("Tcoin",PlayerPrefs.GetInt("Tcoin") - b);
            PlayerPrefs.SetInt("Tarbre", PlayerPrefs.GetInt("Tarbre") - c);
            PlayerPrefs.SetInt("rare", PlayerPrefs.GetInt("rare") - d);


            textCoin.text = PlayerPrefs.GetInt("Tcoin").ToString();
            textArbre.text = PlayerPrefs.GetInt("Tarbre").ToString();
            textmira.text = PlayerPrefs.GetInt("Tmira").ToString();
            textbigo.text = PlayerPrefs.GetInt("Tbigo").ToString();
            textstar.text = PlayerPrefs.GetInt("Tstar").ToString();
            textrare.text = PlayerPrefs.GetInt("rare").ToString();



            x = 1;

        }
        return x;
    }
    



    public void AddTimeStar()
    {

        if((star.transform.position.x<185) & ( VerifierAdditionS(int.Parse(ObligeStarS.text), int.Parse(ObligeStarC.text), int.Parse(ObligeStarA.text), int.Parse(ObligeStarR.text)) == 1 ))
        {

            PlayerPrefs.SetFloat("TimeAddS", PlayerPrefs.GetFloat("TimeAddS") + 1.1f);
            star.transform.Translate(157.13f / 14, 0, 0);
            PlayerPrefs.SetFloat("StarSlidermove", star.transform.position.x);



            ObligeStarS.text = (int.Parse(ObligeStarS.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeBigoB", int.Parse(ObligeBigoB.text));

            ObligeStarC.text = (int.Parse(ObligeStarC.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeBigoC", int.Parse(ObligeBigoC.text));

            ObligeStarA.text = (int.Parse(ObligeStarA.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeBigoA", int.Parse(ObligeBigoA.text));

            ObligeStarR.text = (int.Parse(ObligeStarR.text) + 1).ToString();
            PlayerPrefs.SetInt("ObligeStarR", int.Parse(ObligeBigoR.text));


            x = 0;


        }


    }

    public void AddTimeBigo()
    {
        if ((bigo.transform.position.x < 185) & (VerifierAdditionB(int.Parse(ObligeBigoB.text), int.Parse(ObligeBigoC.text), int.Parse(ObligeBigoA.text), int.Parse(ObligeBigoR.text)) == 1))
        {
            PlayerPrefs.SetFloat("TimeAddB", PlayerPrefs.GetFloat("TimeAddB") + 1.1f);
            bigo.transform.Translate(157.13f / 14, 0, 0);
            PlayerPrefs.SetFloat("BigoSlidermove", bigo.transform.position.x);

            ObligeBigoB.text = (int.Parse(ObligeBigoB.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeBigoB", int.Parse(ObligeBigoB.text));

            ObligeBigoC.text = (int.Parse(ObligeBigoC.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeBigoC", int.Parse(ObligeBigoC.text));

            ObligeBigoA.text = (int.Parse(ObligeBigoA.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeBigoA", int.Parse(ObligeBigoA.text));

            ObligeBigoR.text = (int.Parse(ObligeBigoR.text) + 1).ToString();
            PlayerPrefs.SetInt("ObligeBigoR", int.Parse(ObligeBigoR.text));


            x = 0;
        }

    }
    public void addtimemira()
    {

        if ((PlayerPrefs.GetFloat("TimeAddM") < 15.5f)&(VerifierAdditionM(int.Parse(ObligeMiraM.text), int.Parse(ObligeMiraC.text), int.Parse(ObligeMiraA.text), int.Parse(ObligeMiraR.text))==1))
        {
            PlayerPrefs.SetFloat("TimeAddM", PlayerPrefs.GetFloat("TimeAddM") + 1.1f);
            mira.transform.Translate(157.13f / 15, 0, 0);
            PlayerPrefs.SetFloat("MiraSlidermove", mira.transform.position.x);

            ObligeMiraM.text = (int.Parse(ObligeMiraM.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeMiraM", int.Parse(ObligeMiraM.text));

            ObligeMiraC.text = (int.Parse(ObligeMiraC.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeMiraC", int.Parse(ObligeMiraC.text));

            ObligeMiraA.text = (int.Parse(ObligeMiraA.text) + 5).ToString();
            PlayerPrefs.SetInt("ObligeMiraA", int.Parse(ObligeMiraA.text));

            ObligeMiraR.text = (int.Parse(ObligeMiraR.text) + 1).ToString();
            PlayerPrefs.SetInt("ObligeMiraR", int.Parse(ObligeMiraR.text));

            x =0;
        }

    }
    public void returns ()
    {
        SceneManager.LoadScene(0);   
    }

        public void goCam ()
    {
        SceneManager.LoadScene(4);
        
    }
    // Update is called once per frame
    void Update()
    {


        if(chshop == "add")
        {
          
            AllAdd.SetActive(true);
            ALLPlayer.SetActive(false);
            AllMap.SetActive(false);
        }
        else if (chshop == "player")
        {
           
            AllAdd.SetActive(false);
            AllMap.SetActive(false);
            ALLPlayer.SetActive(true);
        }
        else if(chshop == "map")
        {
            AllAdd.SetActive(false);
            ALLPlayer.SetActive(false);
            AllMap.SetActive(true);
        }


   
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}











