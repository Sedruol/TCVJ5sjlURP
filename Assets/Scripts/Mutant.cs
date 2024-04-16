using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutant : MonoBehaviour
{
    private Animator animationMutant;
    // Start is called before the first frame update
    void Start()
    {
        animationMutant = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animationMutant.SetTrigger("Dash");
        }
    }
}
