using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.

// En este Script, solo se define en la primera parte una variable de tipo publica, en la segunda dirige la vista a esta variable.

public class Look : MonoBehaviour
{ public Transform look;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(look);
    }
}
