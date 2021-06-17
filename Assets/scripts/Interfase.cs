using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfase : MonoBehaviour
{
    public Text nombreTxt;
    public Text vidaTxt;
    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponentInParent<Player>();
        StartCoroutine(AsignarDatos(2.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
