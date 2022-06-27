using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressedleft;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressedleft = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressedleft = false;
    }
}