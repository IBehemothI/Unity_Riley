using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManejo : MonoBehaviour
{
    public int puntos = 10;
    private float aux = 0;
    IEnumerator esperar()
    {
        yield return new WaitForSeconds((float)1.5);
        SimpleSampleCharacterControl.m_moveSpeed = aux;
        SimpleSampleCharacterControl.m_turnSpeed = 150;
        Puntaje.puntajeValor += puntos;
        Destroy(gameObject);
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Personaje"))
        {
            aux = SimpleSampleCharacterControl.m_moveSpeed;
            SimpleSampleCharacterControl.m_moveSpeed = 0;
            SimpleSampleCharacterControl.m_turnSpeed = 0;
            StartCoroutine(esperar());
        }
    }
}
