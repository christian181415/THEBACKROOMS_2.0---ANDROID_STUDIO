using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditosScript : MonoBehaviour
{
    public GameObject creditos;

    public void MostrarCreditos()
    {
        if (creditos.activeSelf==false)
            creditos.SetActive(true);
        else
            creditos.SetActive(false);
    }
}
