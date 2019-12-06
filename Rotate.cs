using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se define el movimmiento de rotacion

public class Rotate : MonoBehaviour
{

    float rot;
    // Update is called once per frame
    void Update()
    {
         rot += Input.GetAxis("Horizontal2")*2;
        //rot = Mathf.Clamp(rot, -60,60);

        // Se define el movimiento con el "Quaternion" en los ejes frente, atras, derecha, izquierda
        
        transform.rotation = Quaternion.Euler(0, rot, 0);

        //if (rot <= -60||rot >= 60 )
        //{
        //    transform.rotation = Quaternion.LookRotation(Vector3.forward.normalized*Time.deltaTime);
            
        //}
        //transform.Rotate (0, rot * 1f, 0);


    }
}
