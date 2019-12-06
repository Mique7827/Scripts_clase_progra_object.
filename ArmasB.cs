using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se mandan a llamar elementos del Script "Armas" para añadirles un valor de daño y añadir las armas "magnum" y "Cuchillo"

public class ArmasB : MonoBehaviour

// Se busca en el enlistado de de armas las armasPunzocortantes y de fuego
{
    public List<Armas> armasPunzocortantes;
    public List<Armas> armasDeFuego;

    // Se añadieron 2 armas nuevas

    // Start is called before the first frame update
    void Awake()
    {
        armasPunzocortantes.Add(new Armas("Cuchillo", 10));
        armasDeFuego.Add(new Armas("Magnum", 50, 6));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
