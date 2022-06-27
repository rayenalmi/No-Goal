using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    public GameObject[] player;
    Color ColorStart;
    // Start is called before the first frame update
    void Start()
    {

        ColorStart.a = 1;
        ColorStart.g = PlayerPrefs.GetFloat("color,G");
        ColorStart.b = PlayerPrefs.GetFloat("color,B");
        ColorStart.r = PlayerPrefs.GetFloat("color,R");
        choose(PlayerPrefs.GetInt("PLAYER"));


       
    }

    void choose(int b)
    {

        int i;
        for (i = 0; i < player.Length; i++)
        {
            if (b == i)
            {
                player[b].SetActive(true);
                player[b].GetComponent<SpriteRenderer>().color = ColorStart;
            }
            else
            {
                player[i].SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
