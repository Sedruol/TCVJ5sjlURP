using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            audioSource.clip = music1;
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            audioSource.clip = music2;
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.clip = music3;
            audioSource.UnPause();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            audioSource.Pause();
        }
    }
}
