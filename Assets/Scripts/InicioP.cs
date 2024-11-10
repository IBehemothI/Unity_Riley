using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InicioP : MonoBehaviour
{
    public GameObject mensaje;
    public GameObject panel;
    public TextMeshProUGUI texto;
    public float borde;
    void Awake()
    {
        texto.outlineWidth = borde;
        Time.timeScale = 0;
        mensaje.SetActive(true);
        panel.SetActive(true);
        SimpleSampleCharacterControl.m_moveSpeed = 7;
        SimpleSampleCharacterControl.m_turnSpeed = 150;
    }

    public void Continuar()
    {
        Time.timeScale = 1;
        mensaje.SetActive(false);
        panel.SetActive(false);
    }
}
