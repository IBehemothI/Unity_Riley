using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Curacion : MonoBehaviour
{
    private int vidaaux;
    private int puntajeaux;
    public int costopocion = 40;
    public int curapocion = 20;
    private float auxf = 0;
    private int auxi = 0;
    public JoyBTN1 joybtn;
    public GameObject avisoPuntos;
    public GameObject avisoVida;
    private int tiempoespera = 2;
    public SimpleHealthBar healthBar;
    // Start is called before the first frame update
    public void CurarBTN()
    {
        StartCoroutine(Curar());
    }
    IEnumerator Curar()
    {
        vidaaux = (int) ScriptVida.vidaInicial;
        puntajeaux = Puntaje.puntajeValor;
        if (vidaaux == 100)
        {
            avisoVida.SetActive(true);
            yield return new WaitForSeconds(tiempoespera);
            avisoVida.SetActive(false);
        }
        else if (puntajeaux < costopocion)
        {
            avisoPuntos.SetActive(true);
            yield return new WaitForSeconds(tiempoespera);
            avisoPuntos.SetActive(false);
        }
        else
        {
            auxf = ScriptVida.vidaInicial += curapocion;
            auxi = (int)auxf;
            if (auxi >= 100)
            {
                ScriptVida.vidaInicial = 100;
                Puntaje.puntajeValor -= costopocion;
                healthBar.UpdateBar(ScriptVida.vidaInicial, 100);
            }
            else
            {
                ScriptVida.vidaInicial += curapocion;
                Puntaje.puntajeValor -= costopocion;
                healthBar.UpdateBar(ScriptVida.vidaInicial, 100);
            }
        }
    }
}
