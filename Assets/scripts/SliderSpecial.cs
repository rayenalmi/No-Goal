using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderSpecial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mira;
    public GameObject bigo;
    public GameObject star;

    float longeur = 129.4f - 19.2f,pas;
    void Start()
    {
       // PlayerPrefs.SetFloat("TimeM", 6.1f);
    }
    // new vector3 (12.2f,429.1f,0.0f) depaert
    // nex vertor3 (129.4f,429.1f,0.0f) arrive
    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (PlayerPrefs.GetInt("trm") == 1)
        {
            pas = longeur / (PlayerPrefs.GetFloat("TimeM") / 0.02f);
            mira.transform.Translate(pas, 0, 0);
        }
        if(mira.transform.position.x>129.1f)
        {
            PlayerPrefs.SetInt("trm", 0);
            mira.transform.position = new Vector3(12.2f, 429.1f, 0.0f);
        }






        if (PlayerPrefs.GetInt("trb") == 1)
        {
            pas = longeur / (PlayerPrefs.GetFloat("TimeB") / 0.02f);
            bigo.transform.Translate(pas, 0, 0);
        }
        if (bigo.transform.position.x > 129.1f)
        {
            PlayerPrefs.SetInt("trb", 0);
            bigo.transform.position = new Vector3(12.2f, 429.1f, 0.0f);
        }

       



       if(PlayerPrefs.GetInt("trs")==1)
        {
            pas = longeur / (PlayerPrefs.GetFloat("TimeS") / 0.02f);
            star.transform.Translate(pas, 0, 0);
        }
        if (star.transform.position.x > 129.1f)
        {
            PlayerPrefs.SetInt("trs", 0);
            star.transform.position = new Vector3(12.2f, 429.1f, 0.0f);
        }

    


    }
}
