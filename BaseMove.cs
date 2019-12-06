using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se define el movimiento y rotacion del personaje conforme a su Rig y movimiento del mouse

public class BaseMove : MonoBehaviour
{
    //Se crean distintas variables para definir cosas basicas como la animacion de movimiento entre otros

    public float velocidad;
    public float velRot;
    public bool onRotation = false;
    protected Rigidbody rb;
    protected Animator anim;
    protected float hor;
    protected float vert;
    protected float mouseHor;

    //Se protegen los movimientos y Rig de los personajes
    protected void AccesoComponentes()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    //Se protegen los movimientos y la velocidad del personaje en los ejes x, y
    protected void Aceleracion(float v)
    {
        hor = Input.GetAxis("Horizontal")*v*Time.deltaTime;
        vert = Input.GetAxis("Vertical") * v * Time.deltaTime;

        rb.velocity = new Vector3(hor, rb.velocity.y, vert);
  
       

        anim.SetFloat("Velocidad", vert);
        anim.SetFloat("veloLateral", hor);
     

    }

    //En general el resto del Script de abajo define la rotacion al moverser el mouse en eje x, y, teniendo en cuenta si se mueve a la izquierda o derecha

    //Define el movimiento en eje x del mouse
    protected void Rotacion(float r)
    {
        mouseHor = Input.GetAxis("Mouse X") * r*Time.deltaTime;
        rb.AddRelativeTorque(rb.transform.up * mouseHor);

        //var angle = transform.localEulerAngles.y;
        //angle = (angle > 180) ? angle - 360 : angle;

        //Define el movimiento en eje y del mouse

        float angle = transform.localEulerAngles.y;
       
        
        if (transform.localEulerAngles.y > 90 && transform.localEulerAngles.y < 180)
        {
            onRotation = true;
            Debug.Log("estoyrotando");
        }

        if (angle > 180)
        {
           
            angle -= 360;
            
            if (angle <-90 )
            {
                onRotation = true;
                Debug.Log("estoyrotandopalotrolado");
            }
        }

        //Es el numero de tiempo en realizar la accion de la rotacion
        if (onRotation == true)
        {
           
            transform.localEulerAngles = Vector3.zero * Time.time* 0.1f;
            onRotation = false;
        }
        

    }

    #region comprobacion de terreno
    public LayerMask mask;
    protected bool isGrounded()
    {
        Vector3 rayOrigin = GetComponent<Collider>().bounds.center;
        float rayDistance = GetComponent<Collider>().bounds.extents.y + 0.01f;
        Ray ray = new Ray();
        ray.origin = rayOrigin;
        ray.direction = Vector3.down;
        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        //Detecta la colision de un objeto hacia el terreno para generar alguna accion
        if (Physics.Raycast(ray.origin, ray.direction, rayDistance, mask))
        {
            Debug.Log("Esta chocando");
            return true;
        }
        else
            return false;
    }
    #endregion

}
