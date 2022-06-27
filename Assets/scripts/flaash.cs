using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaash : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cage;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("pausedeth") != 1)
        {
            transform.Translate(cage.transform.position.x + 0.2f, cage.transform.position.y + 2.5f, 0);
        }
    }
}
