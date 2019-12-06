using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz


// Expliacion General del Script.
// En este Script se define los datos principales del conejo como vida, magia entre otros

public class crear_enem : Agente
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    Animator animconejo;

    /* lugar de donde se van a sacar los datos*/
    EnemigoB enemigoB;
    
    // Start is called before the first frame update
    void Start()
    {
        enemigoB = FindObjectOfType<EnemigoB>();
        BusquedaEnemigo(Id);
        animconejo = GetComponent<Animator>();
    }

    private void BusquedaEnemigo(string id)
    {
        /*Identificar BusquedaEnemigo que no existia antes */
        for (int i = 0; i < enemigoB.enemigo.Count; i++)
        {/*si el id que esta dentro del parametro, busca el dato y que haga una igualdad
dentro del nombre, se regresan datos especificos*/
            if (id == enemigoB.enemigo[i].nombre)
            {
                /* algoritmo de busqueda dentro de i*/
                nombre = enemigoB.enemigo[i].nombre;
                vida = enemigoB.enemigo[i].vida;
                magia = enemigoB.enemigo[i].magia;
            }
        }

    }
    // Manda a llamar la velocidad para el conejo a "destino"
    private void Update()
    {
        ConfigurarDestino(destino);
        animconejo.SetFloat("velocidad", velocidad);
    }
}