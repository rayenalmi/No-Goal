using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTerrain : MonoBehaviour
{
    public GameObject[] terrain ;
    // Start is called before the first frame update
    void Start()
    {
        choose(PlayerPrefs.GetInt("map"));
    }


    void choose(int a)
    {
        for (int i = 0; i < terrain.Length; i++)
        {
            if (i == a)
            {
                terrain[i].SetActive(true);
            }
            else
            {
                terrain[i].SetActive(false);
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
