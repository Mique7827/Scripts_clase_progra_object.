using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se le dan valores establecidos a las armas dentro del videojuego, no hay mucho que explicar realmente, abajo solo se estan mandando a llamar los nombres de las variables como nombre, daño, municion y extra por explosion.

[System.Serializable]
public class Armas

{
    public string nombre;
    public int daño;
    public int municion;
    public int ExtraPorExplosion;

    //Armas punzocortantes.
    public Armas(string n, int d)
    {
        this.nombre = n;
        this.daño = d;
    }

    //Armas de fuego.
    public Armas(string n, int d, int m)
    {
        this.nombre = n;
        this.daño = d;
        this.municion = m;
    }
}
