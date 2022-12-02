using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScriptLaberint : MonoBehaviour
{
    public string Scene;
    public void PlayGame()
    {
        SceneManager.LoadScene(Scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
