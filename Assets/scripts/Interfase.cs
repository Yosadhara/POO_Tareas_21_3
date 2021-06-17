using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfase : MonoBehaviour
{
    [Header ("Interfaces basicas")]
    public TexT nombreTxT;
    public TexT vidaTxT;
    [Header("Interfaces TMPro")]

    public TexT nombreTxTP;
    public TexT vidaTxTP;

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
        if (nombreTxT != null)
        {
            nombreTxT.text = playerData.nombre();
        }
        if (vidaTxT != null)
        {
            vidaTxT.text = playerData.vida.ToString();
        }
        if (nombreTxTP != null)
        {
            nombreTxTP.text = playerData.nombre;
        }
        if (vidaTxTP != null)
        {
            vidaTxTP.text = playerData.vida.ToString();
        }
    }

    {
        IEnumerator AsignarDatos (float waitTime)
        {
            yield return new WaitForSecond (waitTime);
            if (nombreTxT != null)
            {
                nombreTxT.text =playerData.nombre;
            }
            if (vidaTxT != null)
            {
                vidaTxT.text = playerData.vida.ToString();
            }
            if(nombreTxTP != null)
            {
                nombreTxTP.text = playerData.nombre;
            }
            if(vidaTxTP != null)
            {
                vidaTxTP.text = playerData.vida.ToString();
            }

        }
    }
}
