using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemigo : MonoBehaviour
{
     public ConstructorEnemigo[] nuevoJugador;

    // Update is called once per frame
    void Awake()
    {
        nuevoJugador = new ConstructorEnemigo[2];

        nuevoJugador[0] = new ConstructorEnemigo(1, "Sr.Pato", 10,6);

        nuevoJugador[1] = new ConstructorEnemigo(2, "Leopardo Blanco", 20,5);
    
    }
}
