using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.



// Pausa el videojuego.
public class EscalaTiempo : MonoBehaviour
{
    bool pausa; // si es false No hay pausa, si es true, estará pausado

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pausa == false)
            {
                Time.timeScale = 0;
                pausa = true;
            }
            else
            {
                Time.timeScale = 1;
                pausa = false;
           
            }



        }
           
        
    }
}
