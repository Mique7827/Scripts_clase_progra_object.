using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se le da una variable a los valores de nombre, vida, magia, enemigo, definido por los valores int y string

/* sirve para hacer invocaciones, metodo constructor (Bob)*/
[System.Serializable]
    public class Enemigo 
    {
        public string nombre;
        public int vida;
        public int magia;
        public Enemigo(int v, int m, string n)
        {
            /*llave de acceso de datos almacenados en enemigos*/
            this.nombre = n;
            this.vida = v;
            this.magia = m;
        }
    }


