using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{

    public float daño;

    private void OncollisionEnter (Collision other)

    //Iniciacion del daño al enemigo
    if (other.gameObject.tag == "Player")
    {
        other.gameObject.GetComponent<DanoPlayer>().damage(daño);
    }
}
