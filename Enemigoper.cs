using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script se esta buscando la varible "PlayerPosition" con el Void Start (antes de empezar el juego) para que una vez empezado siga a "PlayerPosition"

// Con el public class se estan mandando a llamar elementos de el Script "Persecucion"

public class Enemigoper : Persecucion
{
    // Busca el objeto "player"
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Una vez empezado el juego se perseguira el objeto

    // Update is called once per frame
    void Update()
    {
        Perseguir(playerPosition, this.gameObject.transform);
    }
}
