using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerMision : MonoBehaviour
{
    public GameObject botonNivel;
    public int valordef = 100;
    // Update is called once per frame
    private void Awake()
    {
        Update();
    }
    void Update()
    {
        if (Puntaje.puntajeValor % valordef == 0 && Puntaje.puntajeValor!= 0)
        {
            botonNivel.SetActive(true);
        }
        else
        {
            botonNivel.SetActive(false);
        }
    }
}
