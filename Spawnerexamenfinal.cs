using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.

// Controla la generacion de monedas cada 20 segundos.
public class Spawner : MonoBehaviour
{

    public GameObject prefaMoneda;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarMoneda", 0, 20);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerarMoneda() //Definición
    {
        Instantiate(prefaMoneda);
    }


}
