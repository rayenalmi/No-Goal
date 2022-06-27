using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SPINB : MonoBehaviour
{
    public GameObject exit;
    public GameObject sppin;
    bool tr ;
    int i = 25;
    // Start is called before the first frame update
    void Start()
    {
        
        exit.SetActive(false);
    }
    public void BOUTTONS()
    {
        Time.timeScale = 1;
        i += Random.Range(70,150);
        tr = true;
        sppin.SetActive(false);
    }
        
    public void retour()
    {
       PlayerPrefs.SetInt("score",PlayerPrefs.GetInt("score")+1);

        SceneManager.LoadScene(1);

    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
    // Update icalled once per frame
    void Update()
    {
        if (tr == true)
        {
            if (i != 0)
            {
                transform.Rotate(0, 0, 7.5f);
                i--;
            }
            else if (i == 0)
            {
                exit.SetActive(true);

                if (PlayerPrefs.GetString("chspin") == "vert")
                {
                   
                    //    nb1 = PlayerPrefs.GetInt("Tbigo");
                    PlayerPrefs.SetInt("Tbigo",PlayerPrefs.GetInt("Tbigo")+1);
                }
                if (PlayerPrefs.GetString("chspin") == "viollet")
                {
                   
                    //   nb2 = PlayerPrefs.GetInt("Tstar");
                    PlayerPrefs.SetInt("Tstar", PlayerPrefs.GetInt("Tstar")+1);

                }

                if (PlayerPrefs.GetString("chspin") == "blanc")
                {
                    
                    //  nb3 = PlayerPrefs.GetInt("Tmira");
                    PlayerPrefs.SetInt("Tmira", PlayerPrefs.GetInt("Tmira")+1);
                }

                if (PlayerPrefs.GetString("chspin") == "aaaa")
                {
                    
                    //    nb4 = PlayerPrefs.GetInt("Tcoin");
                    PlayerPrefs.SetInt("Tcoin", PlayerPrefs.GetInt("Tcoin") + 1);
                }

                if (PlayerPrefs.GetString("chspin") == "marron")
                {
                    
                    //   nb5 = PlayerPrefs.GetInt("Tvie");
                    PlayerPrefs.SetInt("Tvie", PlayerPrefs.GetInt("Tvie") + 1);
                }


                if (PlayerPrefs.GetString("chspin") == "rouge")
                {
                    
                    //   nb6 = PlayerPrefs.GetInt("Tarbre");
                    PlayerPrefs.SetInt("Tarbre", PlayerPrefs.GetInt("Tarbre") + 1);
                }

                PlayerPrefs.SetString("chspin", "");
               

            }

        }
       
        }
}
