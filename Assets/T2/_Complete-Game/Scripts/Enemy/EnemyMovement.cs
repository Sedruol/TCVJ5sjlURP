using UnityEngine;
using System.Collections;
//añadir la liberia que nos permita usar NavMeshAgent

namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform player;               // Nos ayudará a saber la posición del player
        PlayerHealth playerHealth;      // Nos ayudará a saber la vida del player
        EnemyHealth enemyHealth;        // Nos ayudará a saber la vida del enemigo
        UnityEngine.AI.NavMeshAgent nav;               // Referencia a nav mesh agent.


        void Awake ()
        {
            // Set up the references.
            player = GameObject.FindGameObjectWithTag ("Player").transform;
            playerHealth = player.GetComponent <PlayerHealth> ();
            enemyHealth = GetComponent <EnemyHealth> ();
            nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();//le asignamos el componente nav mesh agent
        }


        void Update ()
        {
            //Si el enemigo y el jugador aun tienen vida
            if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
            {
                //cambia el destino del nav mesh agent para que vaya donde el player
                // ... set the destination of the nav mesh agent to the player.
                nav.SetDestination (player.position);
            }
            // caso contrario...
            else
            {
                // ... desactivamos el nav mesh agent.
                nav.enabled = false;
            }
        }
    }
}