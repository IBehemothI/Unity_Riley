using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public static bool JuegoPausado = false;
    public GameObject MenuPausa;
    public void Pausar()
    {
        if (JuegoPausado)
        {
            Time.timeScale = 1;
            JuegoPausado = false;
            MenuPausa.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            JuegoPausado = true;
            MenuPausa.SetActive(true);
        }
    }
    public void Salir()
    {
        SceneManager.LoadScene("Menú");
        if (GameObject.FindGameObjectsWithTag("Puntaje").Length >= 1)
        {
            Destroy(GameObject.FindGameObjectsWithTag("Puntaje")[0]);
        }
    }
}
