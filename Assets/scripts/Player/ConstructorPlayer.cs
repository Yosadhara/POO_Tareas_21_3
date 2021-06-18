using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class ConstructorPlayer : MonoBehaviour
{
    //estos son los atributos o las porpiedades
    
    
        public string nombre;
        public int playerId;
        public float vida;
        private int daño;
        public float velocidad;
        private Transform posicionActual;
        private Transform transformacion;
    

    //esto son los metodos y los comportamientos del jugador

   public ConstructorPlayer(int id, string n, float vida, float vel)
   {
       this.playerId = id;
       this.nombre = n;
       this.vida = vida;
       this.velocidad = vel;
   }
}
