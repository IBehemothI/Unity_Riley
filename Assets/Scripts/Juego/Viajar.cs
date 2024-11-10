using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viajar : MonoBehaviour
{
    public GameObject personaje;
    public Camera casa;
    public Camera ciudad;
    public int estado = 0;
    public Zoom script;
    public Zoom script1;
    public void Cambiar()
    {
        if (estado == 0)
        {
            script.enabled = true;
            script1.enabled = false;
            personaje.transform.position = new Vector3(97, 3, -208);
            casa.enabled = false;
            ciudad.enabled = true;
            estado = 1;
        }
        else
        {
            script.enabled = false;
            script1.enabled = true;
            personaje.transform.position = new Vector3(-2, 3, -107);
            casa.enabled = true;
            ciudad.enabled = false;
            estado = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
