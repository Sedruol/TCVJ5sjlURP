using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : MonoBehaviour
{
    [SerializeField] private Transform otherObject;
    private float distance = 0f;
    private Animator animationMutant;
    [SerializeField] private float speed = 0;
    [SerializeField] private int num = 0;
    private void Start()
    {
        animationMutant = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {//IMPORTANTE: se debe colocar el nombre correcto del parámetro
        animationMutant.SetBool("IsRunning", true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && Input.GetKey(KeyCode.LeftShift))//Presione la tecla X?
        {
            Debug.Log("entre");
            speed += 0.5f;
            animationMutant.SetFloat("Speed", speed);//IMPORTANTE: se debe colocar el nombre correcto del parámetro
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            animationMutant.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animationMutant.SetBool("IsRunning", false);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            speed -= 0.5f;
            animationMutant.SetFloat("Speed", speed);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            num++;
            animationMutant.SetInteger("Num", num);//IMPORTANTE: se debe colocar el nombre correcto del parámetro
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            animationMutant.SetTrigger("Jump");//IMPORTANTE: se debe colocar el nombre correcto del parámetro
        }
        else if (Input.GetButtonDown("Fire1"))//Presione el botón izquierdo del mouse
        {
            animationMutant.SetTrigger("Attack");//IMPORTANTE: se debe colocar el nombre correcto del parámetro
        }
        else if (Input.GetButtonDown("Fire2"))//Presione el botón derecho del mouse
        {
            distance = Vector3.Distance(transform.position, otherObject.position);
            Debug.Log("El paladin y la mina se encuentran a una distancia de " + distance + " unidades");
        }
    }
}