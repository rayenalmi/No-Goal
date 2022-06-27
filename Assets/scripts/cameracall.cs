using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cameracall : MonoBehaviour
{
    public int numCam=0;
    static WebCamTexture backcam;
    WebCamDevice[] devices;
    // Start is called before the first frame update
    void Start()
    {
        if(backcam == null)
        {
                devices = WebCamTexture.devices;
                 if (Application.platform == RuntimePlatform.WindowsEditor)
                 {
                    
                   backcam = new WebCamTexture(devices[numCam].name);   
                 }
                 else
                 {
                      transform.Rotate(-90.0f,0.0f,0.0f);
                backcam = new WebCamTexture(devices[numCam].name);      
                 }
               
        }

        GetComponent<Renderer>().material.mainTexture = backcam;


        if(!backcam.isPlaying)
        {
            backcam.Play();        
        }   
    }

        public void returns ()
    {
        SceneManager.LoadScene(3);   
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
