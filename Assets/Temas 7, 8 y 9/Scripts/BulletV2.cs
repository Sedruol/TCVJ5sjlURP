using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletV2 : MonoBehaviour
{
    public static int damage = 20;//variable de da�o
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dmg: " + damage);
        if (other.gameObject.CompareTag("Enemy"))
        {
            MeteorHP meteorHP = other.gameObject.GetComponent<MeteorHP>();
            if (meteorHP != null)
            {
                // ... el enemigo sufrir� da�o.
                meteorHP.TakeDamage(damage, other.transform.position);
            }
            PlayerMoveV2.numBullets--;//numBullets=numBullets-1;
            Destroy(this.gameObject);
        }
    }
}