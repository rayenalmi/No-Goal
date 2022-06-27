using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{//11.21627
   
    float t;

    void OnTriggerExit2D(Collider2D cc)
    {
        if(cc.gameObject.name=="cage")
        {
             transform.position += (3 * Vector3.up * GetComponent<SpriteRenderer>().bounds.size.x);
        }
    }


}


 
