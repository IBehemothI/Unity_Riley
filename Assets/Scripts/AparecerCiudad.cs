using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerCiudad : MonoBehaviour
{
    private GameObject objeto;
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    private int xPos;
    private double yPos;
    private int zPos;
    private Vector3 rotacion;
    private int contador = 0;
    public int cantidad;
    public float tiempoAparecer;
    private int randomAparecer = 0;
    private int randomAnimal = 0;
    private int randomGiro = 0;
    public System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AparecerAnimales());
    }
    // Update is called once per frame
    IEnumerator AparecerAnimales()
    {
        while (contador < cantidad)
        {
            randomAparecer = rnd.Next(1, 3);
            yPos = 3.14;
            if (randomAparecer == 1)
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
                xPos = Random.Range(95, 135);
                zPos = Random.Range(-247, -223);
                Instantiate(objeto, new Vector3(xPos, (float)yPos, zPos), Quaternion.Euler(0, randomGiro, 0));
                yield return new WaitForSeconds(tiempoAparecer);
                contador = contador + 1;
            }
            else if (randomAparecer == 2)
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
                xPos = Random.Range(91, 110);
                zPos = Random.Range(-220, -208);
                Instantiate(objeto, new Vector3(xPos, (float)yPos, zPos), Quaternion.Euler(0, randomGiro, 0));
                yield return new WaitForSeconds(tiempoAparecer);
                contador = contador + 1;
            }
        }
    }
}
