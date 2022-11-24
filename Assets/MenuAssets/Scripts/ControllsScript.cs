using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllsScript : MonoBehaviour
{
    public GameObject imagen;

    public void MostrarControles()
    {
        if (imagen.activeSelf == false)
        {
            imagen.SetActive(true);
        }else
        {
            imagen.SetActive(false);
        }
    }
}
