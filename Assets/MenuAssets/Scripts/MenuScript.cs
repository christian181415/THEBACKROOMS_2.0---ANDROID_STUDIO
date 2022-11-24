using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("LaberintScene");
    }

    public void ControlsGame()
    {
        SceneManager.LoadScene("ControlsScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
