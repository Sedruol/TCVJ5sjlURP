using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocityBullet;//velocidad de las balas
    public ParticleSystem particlesVida;//sistema de particulas
    public AudioSource audioSource;//audio
    public AudioClip modificadorVida;
    public AudioClip trampPuas;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right * velocityBullet);
    }

    private void OnTriggerEnter(Collider other)
    {
        //particles.transform.position = other.transform.position;
        particlesVida.Play();
        //audioSource.Play();
        //Destroy(other.gameObject);
        //=============
        //se activa el modificador de vida
        audioSource.clip = modificadorVida;
        audioSource.Play();
        //==============
        //Se activa el daño de la trampa de puas
        //audioSource.clip = trampPuas;
        //audioSource.Play
    }
}