using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rango : MonoBehaviour
{
    public TextMeshProUGUI textoRango;
    // Update is called once per frame
    public void MostrarRango()
    {
        if (Puntaje.puntajeValor < 100)
        {
            textoRango.text = "Rescatista Novato";
        }
        else if (Puntaje.puntajeValor > 100 && Puntaje.puntajeValor < 500)
        {
            textoRango.text = "Rescatista Aprendiz";
        }
        else if (Puntaje.puntajeValor > 500 && Puntaje.puntajeValor < 1000)
        {
            textoRango.text = "Rescatista Veterano";
        }
        else
        {
            textoRango.text = "Rescatista Experto";
        }
    }
}
