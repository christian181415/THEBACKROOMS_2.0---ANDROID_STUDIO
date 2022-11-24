using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionsScript : MonoBehaviour
{
    private Animator _transicionAnim;
    // Start is called before the first frame update
    void Start()
    {
         _transicionAnim = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(Transicion(scene));
    }
    IEnumerator Transicion(string scene)
    {
        _transicionAnim.SetTrigger("Salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }
}
