using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopPlayer : MonoBehaviour
{
    public GameObject[] a;

    GameObject Couleur;
    int x=0;

    // Start is called before the first frame update
    void Start()
    {
        Couleur = GameObject.FindGameObjectWithTag("COLOR");
    }
    public void ternRight()
    {
       if(x<a.Length -1)
        {
            x++;
            choose(x);
           

        }
       else if (x==a.Length -1)
        {
            x = 0;
            choose(x);
        }
    }  

    void choose(int b)
    {
       
        int i;
        for (i=0;i<a.Length;i++)
        {
            if(b==i)
            {
                a[b].SetActive(true);
            }
            else
            {
                a[i].SetActive(false);
            }

        }
    }

    public void equip()
    {
        PlayerPrefs.SetInt("PLAYER", x);
        PlayerPrefs.SetFloat("color,R", Couleur.GetComponent<ReturnColor>().RBG.r);
        PlayerPrefs.SetFloat("color,B", Couleur.GetComponent<ReturnColor>().RBG.b);
        PlayerPrefs.SetFloat("color,G", Couleur.GetComponent<ReturnColor>().RBG.g);




    }

    public void ternLfeft()
    {
        if(x>0)
        {
            x--;
            choose(x);
            
        }
        else
        {
            x = a.Length -1;
            choose(x);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        a[x].GetComponent<Image>().color = Couleur.GetComponent<ReturnColor>().RBG;
          
      
    }
}

























