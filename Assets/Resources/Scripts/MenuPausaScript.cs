using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausaScript : MonoBehaviour
{
    public GameObject MenuPausa;
    private bool MenuOn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuOn = !MenuOn;
        }

        if(MenuOn==true)
        {
            MenuPausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            MenuPausa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
