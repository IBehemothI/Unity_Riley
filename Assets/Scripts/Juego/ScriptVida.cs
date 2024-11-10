using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScriptVida : MonoBehaviour
{
    public SimpleHealthBar healthBar;
    public GameObject mensaje;
    private int restar = 1;
    public static float vidaInicial = 100;
    void Start()
    {
        healthBar.UpdateBar(vidaInicial, 100);
        StartCoroutine(esperar());
    }

    IEnumerator esperar()
    {
        yield return new WaitForSeconds(2);
        if (vidaInicial > 0)
        {
            vidaInicial = vidaInicial - restar;
            healthBar.UpdateBar(vidaInicial, 100);
            StartCoroutine(esperar());
        }
        else
        {
            vidaInicial = 10;
            mensaje.SetActive(true);
        }
    }
    public void Salir()
    {
        SceneManager.LoadScene("Menú");
    }
}
