using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
    public class Bullet : MonoBehaviour
    {
        public static int damagePerShot = 20;//variable de daño
        //collision? trigger? enter? stay? exit? {
        //el objeto con el que chocó la bala, tiene el tag Shootable?
        //para eso debemos usar if(collision.gameObject.CompareTag("el nombre del tag entre comillas"){
        //con la linea siguiente crearemos una variable de tipo EnemyHealth,
        //la cual tomará el valor de este script siempre y cuando la bala colisione con un enemigo
        //EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        //preguntamos si la variable enemyHealth tiene algún valor con la siguiente linea:
        //if (enemyHealth != null){

        // ... el enemigo sufrirá daño.
        //enemyHealth.TakeDamage(daño, posicion del impacto/colisión);
        //}
        //Destruiremos este objeto
        //}
        //}
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("dmg: " + damagePerShot);
            if (collision.gameObject.CompareTag("Shootable"))
            {
                EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    // ... el enemigo sufrirá daño.
                    //(La variable de tipo EnemyHealth).TakeDamage(daño, posicion del impacto/colisión);
                    enemyHealth.TakeDamage(damagePerShot, collision.transform.position);
                }
                Destroy(this.gameObject);
            }
        }
    }
}