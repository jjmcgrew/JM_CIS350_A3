/*
 * Josh McGrew
 * Assignment 3: Prototype 2
 * destroy moving objects when they go out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //food oob
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //animal oob
        if (transform.position.z < bottomBound)
        {
            //grab health system script and call the takedamage method
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
