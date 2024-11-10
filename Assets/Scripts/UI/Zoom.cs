using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public Transform objetivo;
    public float smoothVelocidad = 0.125f;
    public Vector3 offset;
    private bool esZoom = false;
    public JoyBTN1 joybtn;
    private Vector3 aux;
    public Camera camara;
    public AudioSource Sonido;
    public void PlaySonido()
    {
        Sonido.Play();
    }
    void Start()
    {
        aux = camara.transform.position;
    }
    void FixedUpdate()
    {
        if (joybtn.Presionado && esZoom == true)
        {
            camara.transform.position = aux;
            esZoom = false;
            joybtn.Presionado = false;
        }
        else if (joybtn.Presionado == true && esZoom == false)
        {
            Vector3 posicionDeseada = objetivo.position + offset;
            Vector3 posicionProcesada = Vector3.Lerp(camara.transform.position, posicionDeseada, smoothVelocidad);
            camara.transform.position = posicionProcesada;
            esZoom = true;
            joybtn.Presionado = false;
        }
    }
}
