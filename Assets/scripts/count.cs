using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    public GameObject pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        pos.transform.position = new Vector3(206.5f, 475.9f, 0.0f);
    }
}
