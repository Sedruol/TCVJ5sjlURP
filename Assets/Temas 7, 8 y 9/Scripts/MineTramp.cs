using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineTramp : MonoBehaviour
{
    public int damageMine = 20;
    public float timeToExplode = 5f;
    private float time;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            time = 0f;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            time += Time.deltaTime;
            Debug.Log("tiempo para explotar mina: " + time);
            if (time >= timeToExplode)
            {
                Debug.Log("player hp pre da�o: " + PlayerMoveV2.playerHP);
                PlayerMoveV2.playerHP -= damageMine;
                Debug.Log("player hp post da�o: " + PlayerMoveV2.playerHP);
                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            time = 0f;
        }
    }
}
