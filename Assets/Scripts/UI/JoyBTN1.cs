using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyBTN1 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Presionado;
    public void OnPointerDown(PointerEventData eventData)
    {
        Presionado = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Presionado = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
