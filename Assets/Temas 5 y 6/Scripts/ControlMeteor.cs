using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMeteor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        //other.gameObject.SetActive(false);//desactivamos la bala
        //this.gameObject.SetActive(false);//desactivamos el meteoro
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        //que el player reciba daño
    }
}
