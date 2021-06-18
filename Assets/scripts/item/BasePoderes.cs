using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePoderes : MonoBehaviour
{
    public ConstructorPoderes[] nuevoPoder;

    void Awake()
    {
        nuevoPoder = new ConstructorPoderes[3];
        nuevoPoder[0] = new ConstructorPoderes(1, "bambu");
        nuevoPoder[1] = new ConstructorPoderes(2, "monedas");
        nuevoPoder[2] = new ConstructorPoderes(3, "posion");
    }
}
