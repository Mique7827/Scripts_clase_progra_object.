using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Perez Montiel Miguel Ulises
// No.cuenta:17720441
// Programacion Orientada a Objetos.
// Josue Israel Rivas Diaz

// Expliacion General del Script.
// En este Script

public class Persecucion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;

    // Start is called before the first frame update
    // Este es el codigo para los enemigos que van a percesiguir al jugador, cuando esten a una distancia cerca de el
    void Start()
    {

        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    // ademas el enemigo va tener una cierta velocidad, pero eso se la ponemos enj unity, ya que ciertos enemigos tendran diferente velocidad
    void Update()
    {
        Perseguir(playerPosition, this.gameObject.transform);
    }

    // Realiza el segumiento de enemigo apartir de la distancia y posicion de "player"
    public void Perseguir(Transform player,Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;

        enemigo.LookAt(distancia);
        enemigo.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);



    }


}
