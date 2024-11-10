using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Configuración : MonoBehaviour
{
    public AudioSource Sonido;
    public AudioMixer audioMixer;
    public void SetearVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
        Sonido.Play();
    }
}
