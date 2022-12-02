using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public GameObject objeto;
    
    public void MostrarControles()
    {
        if (objeto.activeSelf==false)
            objeto.SetActive(true);
        else
            objeto.SetActive(false);
    }
}
