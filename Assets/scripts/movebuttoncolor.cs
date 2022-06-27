using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class movebuttoncolor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Canvas parentCanvas;
    public bool buttonPressed;
    float init;
    public float C;

    float max1 = 90.91499f - 8.481003f,x;
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
    public void Start()
    {
        x = max1 / 255;
      
        init = transform.position.y;
        Vector2 pos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform, Input.mousePosition,
            parentCanvas.worldCamera,
            out pos);
    }

    /*
     * 
     * first 8.481003
     * 
     * 
     * last 90.91499
     * 
     * 
     * 
     * */
    

    public void Update()
    {
        C=(((transform.position.x- 8.481003f) /255)/x);
        transform.position = new Vector2(transform.position.x, init);
        
        if(transform.position.x>90.914f)
        {
            transform.position=new Vector2(90.91499f, init);
        }
        if(transform.position.x<8.481003f)
        {
            transform.position = new Vector2(8.481003f, init);
        }


        if (buttonPressed)
        {
            Vector2 movePos;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                parentCanvas.transform as RectTransform,
                Input.mousePosition, parentCanvas.worldCamera,
                out movePos);

            transform.position = parentCanvas.transform.TransformPoint(movePos);
        }
    }
}
