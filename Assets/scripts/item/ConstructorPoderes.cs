using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorPoderes : MonoBehaviour
{
    public int poderId;
    public string nombrePoder;

    public ConstructorPoderes(int id, string x)
    {
        this.poderId =id;
        this.nombrePoder =x;
    }
}
