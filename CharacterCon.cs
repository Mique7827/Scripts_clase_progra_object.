using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se ve el movimiento y el ataque del personaje

// Se definen los valores clave del movimiento de nuestro personaje como: la velocidad, la velocidad del salto y la gravedad del mismo para caer, en si su controlador
public class CharacterCon : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    // Se definen con el animator la animacion del objeto
    private Vector3 moveDirection = Vector3.zero;
    private Animator anim;
    private bool ataque;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
       
    }

    // Se definen los valores clave del movimiento de nuestro personaje como: la velocidad, la velocidad del salto y la gravedad del mismo para caer
    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(0.0f, 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);


        // Determina la rotacion de izquierda y derecha a 90 para que su animacion se active en dichos puntos, ademas de si se aprieta la techa shift, el personaje corra y sino se desactive con el "if"


        if ( moveDirection.z <= 0 ||transform.rotation.y <=-90 || transform.rotation.y >= 90  )
        {
            moveDirection.z *= -speed;
            anim.SetFloat("Speed", moveDirection.z*speed);
        }

        anim.SetFloat("Speed", moveDirection.z * speed);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetLayerWeight(1, 1);
            anim.SetFloat("Run", 7);
        }
        else
        {
            anim.SetLayerWeight(1, 0);
            anim.SetFloat("Run", 0);
        }
        

        AtaqueNormal();
    }


    // Controla el ataque presionado y lo desactiva al soltarlo y el bool controla dicha animacion

    void AtaqueNormal()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ataque = true;
        }
        else
        {
            ataque = false;
        }


        anim.SetBool("AttackNormal", ataque);
    }
}
