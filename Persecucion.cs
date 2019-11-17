using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecucion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;
    // Se esta declarando con el public float para poder modificar la velocidad, al igual que la posicion.
    // Start is called before the first frame update
    void Start()
    {

        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    // Se esta declarando que se va a “perseguir” la posicion.
    // Update is called once per frame
    void Update()
    {
        Perseguir(playerPosition, this.gameObject.transform);
    }

    public void Perseguir(Transform player,Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;

        enemigo.LookAt(distancia);
        enemigo.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);
        // Se esta declarando que seguirá el movimiento del vector que, al mismo tiempo ira asignado al gameobject,Transform.


    }


}
