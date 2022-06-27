using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressedright;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressedright = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressedright = false;
    }
}