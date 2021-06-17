using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string nombre;
    public int playerId;
    public float vida;
    public float velocidad;


    BaseJugador bdJugador;
    // Start is called before the first frame update
    void Start()
    {
        bdJugador = GameObject.FindObjectOfType<BaseJugador>();
        CargarDatos(playerId);
    }

    
    void CargarDatos(int id)
    {
       for (int i = 0; i < bdJugador.nuevoJugador.Length; i++)
       {
           if (bdJugador.nuevoJugador[i].playerId == id)
           {
               this.nombre = bdJugador.nuevoJugador[i].nombre;
               this.vida = bdJugador.nuevoJugador[i].vida;
               this.velocidad = bdJugador.nuevoJugador[i].velocidad;
           }
       }
    }
}
