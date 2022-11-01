using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterScript : MonoBehaviour
{
    private Transform objetivo;
    private NavMeshAgent agente;
    private GameManager gameManager;

    private void Awake()
    {
        objetivo = GameObject.FindGameObjectWithTag("Player").transform;
        agente = GetComponent<NavMeshAgent>();
        gameManager = FindObjectOfType<GameManager>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agente.SetDestination(objetivo.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.Aparecefinal("Game Over");
        }
    }

    /*private IEnumerator tiempoDestruccion()
    {
        for (int i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(1);
        }
        gameManager.CrearNuevoMounstro();
        Destroy(this.gameObject);
    }*/
}
