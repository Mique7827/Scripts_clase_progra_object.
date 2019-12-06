using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se le dan valores de vida y magia a los distintos enemigos 

public class EnemigoB : MonoBehaviour
{
    // Se manda a llamar al enemigo para agregarle los valores de vida y magia


    public List<Enemigo> enemigo;
    // Start is called before the first frame update
    void Awake()
    {
        enemigo.Add(new Enemigo(100, 50, "Bolita asesina"));
        enemigo.Add(new Enemigo(200, 500, "slime de marihuana"));
        enemigo.Add(new Enemigo(300, 50, "Muerto de hambre"));
        enemigo.Add(new Enemigo(300, 100, "skeleton"));
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
