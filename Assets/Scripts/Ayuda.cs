using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ayuda : MonoBehaviour
{
    public GameObject mensaje;
    public GameObject panel;
    public void MostrarAyuda()
    {
        Time.timeScale = 0;
        mensaje.SetActive(true);
        panel.SetActive(true);
    }

    public void Continuar()
    {
        Time.timeScale = 1;
        mensaje.SetActive(false);
        panel.SetActive(false);
    }
}
