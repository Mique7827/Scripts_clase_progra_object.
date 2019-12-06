using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se desarrolla todo el movimiento

public class Mov : MonoBehaviour
{
    //Abarca el visual de las animaciones y sus respectivos controles.
    [Header("Visual")]
    public GameObject model;
    public string[] tipoAtaque;
    public bool tipoMovimiento;

    //Efectos de movimiento y rotación con fuerza angular.
    int contador;
    Animator anim;
    float velocidad;
    float velocidadlateral;
    float rotationSpeed = 2f;
    Quaternion targetModelRotation;

    //Define la velocidad de movimiento
    // Start is called before the first frame update.
    void Start()
    {
        tipoMovimiento = false;
        contador = 0;
        anim = GetComponent<Animator>();
        velocidad = 6;
        velocidadlateral = 6;

        targetModelRotation = Quaternion.Euler(0, 0, 0);
    }


    // Update is called once per frame.
    void Update()
    {
        ControlGeneralMovimiento();
        if (Input.GetMouseButtonDown(0))
        {
            contador++;
            if (contador >= 3)
            {
                contador = 0;
            }
        }
        //CambioAtaque();
        Ataque(contador, "Contador");
    } //Fin de Update.


    //Es el control general de movimiento de el personaje con las animaciones
    void ControlGeneralMovimiento()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            tipoMovimiento = true;
        }
        else
        {
            tipoMovimiento = false;
        }

        if (tipoMovimiento == false)
        {
            anim.SetLayerWeight(0, 1);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 0);
            ControlMovimiento();
        }
        else if (tipoMovimiento == true)
        {
            anim.SetLayerWeight(0, 0);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 1);
            ControlMovimientoAtaque();

        }

        void ControlMovimiento()
        {
            //Detecta el movimiento del mouse
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 direccion = new Vector3(horizontal * velocidadlateral * Time.deltaTime, 0, vertical * velocidad * Time.deltaTime);

            //Transformar el movimiento del personaje para girar.
            model.transform.rotation = Quaternion.Lerp(model.transform.rotation, targetModelRotation, Time.deltaTime * rotationSpeed);

            //Asignación de animaciones al software.
            transform.Translate(direccion);
            anim.SetFloat("Speed", vertical * velocidad);
            anim.SetFloat("Turn", horizontal * velocidadlateral);
            direccion.Normalize();

            //Condicionantes de posicionamiento y registro de coordenadas.
            if (direccion.z > 0)
            {
                targetModelRotation = Quaternion.Euler(0, 0, 0);
            }
            else if (direccion.z < 0)
            {
                targetModelRotation = Quaternion.Euler(0, 180, 0);
            }

            if (direccion.x > 0)
            {
                targetModelRotation = Quaternion.Euler(0, 90, 0);
            }
            else if (direccion.x < 0)
            {
                targetModelRotation = Quaternion.Euler(0, 270, 0);
            }
        }

        void ControlMovimientoAtaque()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 direccion = new Vector3(horizontal * velocidadlateral * Time.deltaTime, 0, vertical * velocidad * Time.deltaTime);

            //Transformar el movimiento del personaje para girar.
            model.transform.rotation = Quaternion.Lerp(model.transform.rotation, targetModelRotation, Time.deltaTime * rotationSpeed);

            //Asignación de animaciones al software.
            transform.Translate(direccion);
            anim.SetFloat("Speed", vertical * velocidad);
            anim.SetFloat("Turn", horizontal * velocidadlateral);
            direccion.Normalize();

            //Condicionantes de posicionamiento y registro de coordenadas.
            if (direccion.z > 0)
            {
                targetModelRotation = Quaternion.Euler(0, 0, 0);
            }
            else if (direccion.z < 0)
            {
                targetModelRotation = Quaternion.Euler(0, 180, 0);
            }

            if (direccion.x > 0)
            {
                targetModelRotation = Quaternion.Euler(0, 90, 0);
            }
            else if (direccion.x < 0)
            {
                targetModelRotation = Quaternion.Euler(0, 270, 0);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            contador++;
            if (contador >= 3)
            {
                contador = 0;
            }
        }

        // Detiene el movimiento en caso de defensa al apretar "Q" con la animacion de defensa
        if (Input.GetKey(KeyCode.Q))
        {
            tipoMovimiento = true;
        }
        else
        {
            tipoMovimiento = false;
        }

        if (tipoMovimiento == false)
        {
            anim.SetLayerWeight(0, 1);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 0);
            ControlMovimiento();
        }
        else if (tipoMovimiento == true)
        {
            anim.SetLayerWeight(0, 0);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 1);
            ControlMovimientoAtaque();

        }

        ControlMovimiento();
        //CambioAtaque();
        Ataque(contador, "Contador");
    }

    /* void Ataque()
     {
         if (Input.GetMouseButtonDown(0))
         {
             anim.SetBool("Attack", true);
         }
         else
         {
             anim.SetBool("Attack", false);
         }
     }*/

    // Lleva a cabo las animaciondes de ataque y combo

    void Ataque(string tipoAtaque)
    {
        if (Input.GetMouseButtonDown(0))
        {
            ComboAtaque();
            anim.SetBool(tipoAtaque, true);
        }
        else
        {
            anim.SetBool(tipoAtaque, false);
        }
    }

    void Ataque(int contador, string contadorText)
    {
        if (Input.GetMouseButtonDown(0))
        {
            contador++;
            anim.SetInteger(contadorText, contador);
            if (contador >= 3)
            {
                contador = 0;
            }
        }
        else
        {
            anim.SetInteger(contadorText, 0);
        }
    }

    void CambioAtaque()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            contador++;
            if (contador > tipoAtaque.Length-1)
            {
                contador = 0;
            }
        }
    }

    void ComboAtaque()
    {
        contador++;
        if (contador > tipoAtaque.Length - 1)
        {
            contador = 0;
        }
    }
}

