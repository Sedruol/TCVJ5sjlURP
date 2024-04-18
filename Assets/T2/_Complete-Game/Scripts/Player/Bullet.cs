using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
    public class Bullet : MonoBehaviour
    {
        public static int damagePerShot = 20;//variable de da�o
        //collision? trigger? enter? stay? exit? {
        //el objeto con el que choc� la bala, tiene el tag Shootable?
        //para eso debemos usar if(collision.gameObject.CompareTag("el nombre del tag entre comillas"){
        //con la linea siguiente crearemos una variable de tipo EnemyHealth,
        //la cual tomar� el valor de este script siempre y cuando la bala colisione con un enemigo
        //EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        //preguntamos si la variable enemyHealth tiene alg�n valor con la siguiente linea:
        //if (enemyHealth != null){

        // ... el enemigo sufrir� da�o.
        //enemyHealth.TakeDamage(da�o, posicion del impacto/colisi�n);
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
                    // ... el enemigo sufrir� da�o.
                    //(La variable de tipo EnemyHealth).TakeDamage(da�o, posicion del impacto/colisi�n);
                    enemyHealth.TakeDamage(damagePerShot, collision.transform.position);
                }
                Destroy(this.gameObject);
            }
        }
    }
}