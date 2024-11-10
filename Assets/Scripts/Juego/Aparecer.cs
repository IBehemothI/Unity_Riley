using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    private GameObject objeto;
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    private int xPos;
    private int yPos;
    private int zPos;
    private Vector3 rotacion;
    private int contador = 0;
    public int cantidad;
    public float tiempoAparecer;
    public System.Random rnd = new System.Random();
    private int randomAnimal = 0;
    private int randomGiro = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AparecerAnimales());
    }
    // Update is called once per frame
    IEnumerator AparecerAnimales()
    {
        yPos = 3;
        rotacion = new Vector3(0, -106, 0);
        while (contador < cantidad)
        {
            randomAnimal = rnd.Next(1, 5);
            if (randomAnimal == 1)
            {
                objeto = objeto1;
            }
            else if (randomAnimal == 2)
            {
                objeto = objeto2;
            }
            else if (randomAnimal == 3)
            {
                objeto = objeto3;
            }
            else if (randomAnimal == 4)
            {
                objeto = objeto4;
            }
            randomGiro = Random.Range(0, 360);
            xPos = Random.Range(-15, 35);
            zPos = Random.Range(-110, -138);
            Instantiate(objeto, new Vector3(xPos, yPos, zPos), Quaternion.Euler(0, randomGiro, 0));
            yield return new WaitForSeconds(tiempoAparecer);
            contador = contador + 1;
        }
    }
}
