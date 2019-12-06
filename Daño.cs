using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se manda a llamar el daño del enemigo para un enemigo que puede ser escogido y causarle daño con la tecla espacio en la barra de vida de -10 

public class Daño : MonoBehaviour
{
    crear_enem dañoEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        dañoEnemigo = GetComponentInParent<crear_enem>();
        Debug.Log(dañoEnemigo.name);
    }

    //causa el daño con la tecla espacio en la barra de vida de -10 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dañoEnemigo.vida-=10;
        }
    }
}
