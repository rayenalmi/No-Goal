using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rapparaitre : MonoBehaviour
{//-2.59 
 //2.54
    public GameObject mira;
    float P,o,i;




    void Awake()
    {
      
    }
    void OnTriggerExit2D(Collider2D cc)
    {
       
        if (cc.gameObject.tag=="stade")
        {
            anather();
           
        }         
    }
   void OnTriggerEnter2D(Collider2D CE)
    {
        if (CE.gameObject.name=="bigo")
        {
            anather();
        }

    }

    void OnCollisionEnter2D(Collision2D cc)
    {
        if (cc.gameObject.name == "cage")
        {
            anather();
           
        }

    }



        void anather()
    {
            P = Random.Range(-2.59f, 2.54f);
        transform.position = new Vector3(P, transform.position.y, transform.position.z);
        transform.Translate(0, 11.21627f*2.1f , 0);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
      
    }
    // Update is called once per frame      int.Parse(sname)
    void FixedUpdate()
    {
        o = PlayerPrefs.GetFloat("kk");

        if (PlayerPrefs.GetInt("pausedeth") != 1)
        {
            transform.Translate(0, -0.035f - o, 0);
        }


        if(GameObject.Find("mira"))
        {
          if(mira.transform.position.x>transform.position.x)
            {
                i = 1;
            }
          else if (mira.transform.position.x < transform.position.x)
            {
                i = -1;
            }
            transform.Translate(0.025f*i,0, 0);
        }
                
                /*  o = transform.position.y - cage.transform.position.y;
        Debug.Log(o);
        if (o < -2.5f)
        {
            P = Random.Range(-2.59f, 2.54f);
            transform.position = new Vector3(P, transform.position.y, transform.position.z);
            transform.Translate(0, 11.21627f * 2.5f, 0);
            transform.Rotate(0, 0, -15);
        }
        */
    }
}
