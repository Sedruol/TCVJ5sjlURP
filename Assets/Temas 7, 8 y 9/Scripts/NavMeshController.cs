using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//añadir la libreria AI
public class NavMeshController : MonoBehaviour
{
    [SerializeField] private Transform objective;//almacenar el transform del objeto que perseguire
    private NavMeshAgent agent;//almacena una variable de tipo NavMeshAgent
    private GameObject enemy; //almacena el objeto enemy
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();//le asignamos el componente NavMeshAgent a la variable agent
        //agent.destination = objective.position;
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        //agent.destination = enemy.transform.position;
        //desactivamos el componente pathfinding (NavMeshAgent)
        //agent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //agent.destination = objective.position;
        agent.SetDestination(objective.position);
        //agent.destination = enemy.transform.position;
    }
}