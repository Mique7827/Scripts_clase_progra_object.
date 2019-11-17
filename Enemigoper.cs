using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigoper : Persecucion
{
    // Se esta declarando que se va a buscar el punto en el que se encuentre el jugador, mandándola a llamar con el player position.
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }
    // Se esta declarando que se va a “perseguir” la posicion.
    // Update is called once per frame
    void Update()
    {
        Perseguir(playerPosition, this.gameObject.transform);
    }
}
