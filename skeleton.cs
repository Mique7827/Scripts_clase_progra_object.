using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se repiten los datos del conejo para poder seguir un "destino" con skeleton

public class skeleton : Agente
{
   
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    public float VelocidadAgente;

    Animator anim;

    /* lugar de donde se van a sacar los datos*/
    EnemigoB enemigoB;

    // Busca el obejto destino mientras lleva a cabo su animacion para acercarse

    // Start is called before the first frame update
    void Start()
    {
        VelocidadAgente = velocidad;

        enemigoB = FindObjectOfType<EnemigoB>();

        BusquedaEnemigo(Id);

        this.anim = GetComponent<Animator>();
        destino = GameObject.Find("Destino").GetComponent<Transform>();
        objetivo = GameObject.Find("Destino").GetComponent<Transform>();
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
    // Si skeleton se encuentra cerca lleva a cabo el ataque y aparecera un "Tomaaaaa" y si no, no hara nada
    void Update()
    {
        if(MedirDistanciaBool())
        {
            if(MedirDistanciaBool())
            ConfigurarDestino(destino);

            if(MedirDistancia() <= freno)
            {
                Debug.Log("Tomaaaaaa");
                anim.SetBool("Ataque", true);
            }
            else
            {


                anim.SetBool("Ataque", false);
            }

        }
        else if(!MedirDistanciaBool())
        {

            VelocidadAgente = 0;

        }

        // Manda a llamar la velocidad para el skeleton a "destino"
        if (anim !=null)
        {

            anim.SetFloat("velocidad", velocidad);

        }
        
    }

}
