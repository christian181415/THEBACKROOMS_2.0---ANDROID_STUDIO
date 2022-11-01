using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject mounstro;
    [SerializeField] GameObject personaje;
    [SerializeField] Transform[] arrayPuntosSalida;
    [SerializeField] GameObject panelFinal;
    [SerializeField] private TextMeshProUGUI textoFinal;

    private int puntoSalida;
    public bool lockCursor = true;

    // Start is called before the first frame update
    void Start()
    {
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        EstablecerPunto(personaje);
        //CrearNuevoMounstro();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Escape ))
            {
                lockCursor = !lockCursor;

                if (lockCursor == true)
                {
                    Time.timeScale = 1f;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
                if (lockCursor == false)
                {
                    Time.timeScale = 0f;
                    Cursor.lockState = CursorLockMode.None;
                }
                
            }
    }

    private void EstablecerPunto(GameObject objeto)
    {
        puntoSalida = Random.Range(0, arrayPuntosSalida.Length);
        objeto.transform.position = arrayPuntosSalida[puntoSalida].position;
    }

    /*public void CrearNuevoMounstro()
    {
        Instantiate(mounstro);
        EstablecerPunto(mounstro);
    }*/

    public void Botones(bool eleccion)
    {
        if (eleccion == true)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            Application.Quit();
        }
    }


    public void Aparecefinal(string texto)
    {
        panelFinal.SetActive(true);
        textoFinal.text = texto;
        Time.timeScale = 0f;
    }
}
