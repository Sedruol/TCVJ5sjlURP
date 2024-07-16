using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace CompleteProject
{
    public class puas : MonoBehaviour
    {
        public PlayerHealth playerHealth;
        public int damagePuas = 15;
        public float timeToMakeDamage = 3f;
        private float time;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                time = 0;
            }

        }
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                time += Time.deltaTime;
                Debug.Log("time " + time);
                if (time > timeToMakeDamage)
                {
                    time = 0;
                    Debug.Log("estoy haciendo daño");
                    playerHealth.TakeDamage(damagePuas);
                }

            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                {
                    time = 0;
                }
            }

        }
    }
}