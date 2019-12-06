using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se hace posible el movimiento del "Enemigo a cierto punto en especifico", mandando a llamarlo a su posicion, desde un punto en epecifico, deteniendolo al tocarlo.

public class Agente : MonoBehaviour

    // El SerializeField evita que la programacion de las variables sea editable o se pueda robar por teceros
{


    protected float velocidad;

    [SerializeField]
    protected Transform destino;
   
    [SerializeField]
    protected float freno;

    [SerializeField]
    protected float distanciaMeta;

    [SerializeField]
    protected Transform objetivo;

    

    // Con el Vector3; el cual es un tipo de variable que toma en cuenta los ejes, x, y, z, se manda una direccion de seguimiento de vista del personaje "conejo" al  empty "destino"

   protected void ConfigurarDestino(Transform d)
   { 
        Vector3 destinoFinal = new Vector3(d.position.x, this.transform.position.y, d.position.z);

        ConfiguracionFreno(destinoFinal, freno);

        transform.LookAt(destinoFinal);

        // Maneja el translado conforme a la velocidad y tiempo en el entorno 

        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        
   }

    // Cuando la distancia de "f" en la variable float es 0 con respecto al "destino", este mismo parara su velocidad
    // Teniendo en cuenta la distancia entre "objetivo" y "metaPos"

    protected bool ConfiguracionFreno(Vector3 d,float f)
    {

        float velocidadlocal = 1;
        float distancia = Vector3.Distance(transform.position, d);
        

       if (distancia < f)
       {
            velocidad = 0;
            return (true);
       }

        else
        {
            velocidad = velocidadlocal;
            return (false);
        }
    }
    // Detecta la distancia entre objetos
    protected float MedirDistancia()
    {
        Vector3 metaPos = new Vector3(objetivo.position.x, this.transform.position.y, objetivo.position.z);
        float distancia = Vector3.Distance(transform.position, metaPos);
        Debug.Log(distancia);
        return distancia;



    }
    // Define la distancia media, si es menor a la establecida lo comenzara a seguir
    protected bool MedirDistanciaBool()
    {
        Vector3 metaPos = new Vector3(objetivo.position.x, this.transform.position.y, objetivo.position.z);
        float distancia = Vector3.Distance(transform.position, metaPos);

        if (distancia < distanciaMeta)
            return true;
        else
            return false;


    }
}   

