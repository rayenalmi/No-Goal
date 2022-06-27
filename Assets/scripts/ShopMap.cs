using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMap : MonoBehaviour
{


    public GameObject [] a;
    int x=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void choose(int b)
    {

        int i;
        for (i = 0; i < a.Length; i++)
        {
            if (b == i)
            {
                a[b].SetActive(true);
            }
            else
            {
                a[i].SetActive(false);
            }

        }
    }

    public void Equip ()
    {
       
        PlayerPrefs.SetInt("map", x);
    }

    public void ternLfeft()
    {
        if (x > 0)
        {
            x--;
            choose(x);

        }
        else
        {
            x = a.Length - 1;
            choose(x);

        }
    }
    public void ternRight()
    {
        if (x < a.Length - 1)
        {
            x++;
            choose(x);


        }
        else if (x == a.Length - 1)
        {
            x = 0;
            choose(x);
        }
    }
}
