using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúPrincipal : MonoBehaviour
{
    public AudioSource Sonido;
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
    public void PlaySonido()
    {
        Sonido.Play();
    }
        public void Salir()
    {
        Application.Quit();
    }
}
