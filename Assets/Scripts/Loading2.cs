using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Loading2 : MonoBehaviour
{
    public GameObject PantallaCargando;
    public Slider slider;
    public TextMeshProUGUI textoProgreso;
    public int escenaindex = 2;
    public void CargarNivel()
    {
        StartCoroutine(CargarAsinc(escenaindex));
    }
    IEnumerator CargarAsinc(int escenaindex)
    {
        AsyncOperation operacion = SceneManager.LoadSceneAsync(escenaindex);
        PantallaCargando.SetActive(true);
        while (!operacion.isDone)
        {
            float progreso = Mathf.Clamp01(operacion.progress / .9f);
            slider.value = progreso;
            textoProgreso.text = Mathf.Round(progreso * 100f) + "%";
            yield return null;
        }
    }
}