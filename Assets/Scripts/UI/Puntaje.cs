using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public static int puntajeValor = 0;
    public TextMeshProUGUI puntaje;
    public static int restar = 1;
    public static float vidaInicial = 100;
    void Start()
    {
        puntaje = GetComponent<TextMeshProUGUI>();
        StartCoroutine(esperar());
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = puntajeValor.ToString();
    }
    IEnumerator esperar()
    {
        yield return new WaitForSeconds(5);
        vidaInicial = vidaInicial - restar;
        StartCoroutine(esperar());
    }
}
