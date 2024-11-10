using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Loading : MonoBehaviour
{
    public GameObject PantallaCargando;
    public GameObject MenuP;
    public Slider slider;
    public TextMeshProUGUI textoProgreso;
    public void CargarNivel(int escenaindex)
    {
        StartCoroutine(CargarAsinc(escenaindex));
    }
    IEnumerator CargarAsinc(int escenaindex)
    {
        AsyncOperation operacion = SceneManager.LoadSceneAsync(escenaindex);
        PantallaCargando.SetActive(true);
        MenuP.SetActive(false);
        while(!operacion.isDone)
        {
            float progreso = Mathf.Clamp01(operacion.progress / .9f);
            slider.value = progreso;
            textoProgreso.text = Mathf.Round(progreso * 100f) + "%";
            yield return null;
        }
    }
}
