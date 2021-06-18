using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorEnemigo : MonoBehaviour
{
     public string nombre;
        public int enemigoId;
        public float vida;
        private int daño;
        public float velocidad;
        private Transform posicionActual;
       
     public ConstructorEnemigo(int id, string n, float vida, float vel)
   {
       this.enemigoId = id;
       this.nombre = n;
       this.vida = vida;
       this.velocidad = vel;
   }
}
