using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    public string NextScene;

    public void SelectGame()
    {
        SceneManager.LoadScene(NextScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
