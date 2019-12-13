using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.


// Gira la camara del personaje.
public class GiroCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Input.GetAxis("Mouse Y"), 0 , 0);
    }
}
