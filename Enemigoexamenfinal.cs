using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.

// Reinicia el juego al toque del enemigo.

public class Enemigo : MonoBehaviour
{


     

    GameObject jugador;


    // Start is called before the first frame update
    void Start()
    {
        // Busca al jugador
        jugador = GameObject.Find("brayan");

    }

    // Update is called once per frame
    void Update()
    {
        // Busca al personaje con la vista, hace que el enemigo siga a el protagonista con la velocidad *1
        transform.LookAt(jugador.transform);
            GetComponent<Rigidbody>().velocity = transform.forward * 1;
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Si colisiona, reinicia el juego.
        if (collision.collider.name == "brayan")
        { 
            Debug.Log("Nos ha golpeado");
            SceneManager.LoadScene(0);
        }
       
    }
}
