using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaberintScript : MonoBehaviour
{
    public string Scene;
    void OnTriggerEnter (Collider other) 
    {   
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
