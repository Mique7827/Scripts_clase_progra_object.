using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.

// Controla el movimiento y las monedas.

public class Movimiento : MonoBehaviour
{

    public float velocidad;
    public int numeromonedas = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Controla la rotacion de izquiera a derecha y de arriba y abajo
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

    }

    // Detecta el toque con las monedas
    private void OnTriggerEnter(Collider other)
   {
	   if(other.name == "Cube A")
	   {
		   Debug.Log("Hemos entrado al cubo A");
		   // GetComponent<AudioSource>().Play();
	   }
	   if(other.tag == "Moneda")
	   {
		   Debug.Log("Hemos tomado una moneda");
		   Destroy(other.gameObject);   //destruimos el ítem recién lo tocas.
            numeromonedas = numeromonedas + 1; //sumam 1 al contador de ítems
	   }
   }
}
