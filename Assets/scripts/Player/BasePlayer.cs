using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugador : MonoBehaviour
{
    public ConstructorPlayer[] nuevoJugador;

    // Update is called once per frame
    void Awake()
    {
        nuevoJugador = new ConstructorPlayer[1];

        nuevoJugador[0] = new ConstructorPlayer(1, "Panda", 15,3);
    }
}
