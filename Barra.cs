using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script controla el movimiento de la barra de vida de 100 a 0


public class Barra : MonoBehaviour
{
    public Slider[] barras;
    public int vida;
    crear_enem vidaEnemigo;

    // Se manda a llamar el elemento "asignarvida" que es el de la barra de vida

    // Start is called before the first frame update
    void Start()
    {
        vidaEnemigo = GetComponentInParent<crear_enem>();
        StartCoroutine("asignarvida");


        
        
    }

    // Cuando la barra de vida llegue a 0 la activacion del objeto sera falsa por ende desaparecera, bajara la vida cada vez que se apriete espacio

    // Update is called once per frame
    void Update()
    {
        barras[0].value = vidaEnemigo.vida;
        if (vidaEnemigo.vida == 0)
        {

            transform.parent.gameObject.SetActive(false);
        }



    }

    // Se define en que punto es el valor de la barra de vida del "enemigo"
    IEnumerator asignarvida()
    {
        yield return new WaitForSeconds(1);
        if(vidaEnemigo !=null)
        {

            vida = vidaEnemigo.vida;
            barras[0].maxValue = vida;
            barras[0].value = barras[0].maxValue;
        }


    }

    // Se define cuanto se deslizara la barra de vida conforme cada vez que se presione.
    IEnumerator asignarBarra()


    {
        yield return new WaitForSeconds(1);
        barras = new Slider[2];
        barras = GetComponentsInChildren<Slider>();
        vida = vidaEnemigo.vida;
        for (int i = 0; i < barras.Length; i++)
        {
            barras[i] = barras[i];
            if (i == 0)
            {
                barras[i].maxValue = vida;
                barras[i].value = barras[i].maxValue;


            }


        }
    }
}
