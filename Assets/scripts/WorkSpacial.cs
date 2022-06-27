using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WorkSpacial : MonoBehaviour
{
    public GameObject Gmira;
    public GameObject Gbigo;
    public GameObject Gsatr;
     GameObject cage;
    // Start is called before the first frame update
    void Start()
    {
        cage = GameObject.FindGameObjectWithTag("cage");




    }
    float timeB, timeM, timeS;
    int i;
  
    // Update is called once per frame
    void Update()
    {
        
       
        if (PlayerPrefs.GetInt("trb")== 1)
            {
                Gbigo.SetActive(true);
            }
        else if(PlayerPrefs.GetInt("trb") == 0)
        {
            Gbigo.SetActive(false);
        }



            if (PlayerPrefs.GetInt("trm") == 1)
            {
                Gmira.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("trm") == 0)
            {
            Gmira.SetActive(false);
            }



        if (PlayerPrefs.GetInt("trs") == 1)
        {
            Gsatr.SetActive(true);
            Gsatr.transform.Rotate(0, 0, 10);
        }
        else if (PlayerPrefs.GetInt("trs") == 0)
        {
            Gsatr.SetActive(false);
        }

        cage = GameObject.FindGameObjectWithTag("cage");
      
        
        Gbigo.transform.position = new Vector3(PlayerPrefs.GetFloat("positioncage"), cage.transform.position.y, 0);
        Gmira.transform.position = new Vector3(Gmira.transform.position.x, cage.transform.position.y, 0);
        Gsatr.transform.position = new Vector3(cage.transform.position.x,cage.transform.position.y + 4.1f, Gsatr.transform.position.z);





     
    }
}
