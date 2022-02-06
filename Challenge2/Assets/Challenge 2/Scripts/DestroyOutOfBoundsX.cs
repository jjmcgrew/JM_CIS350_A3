/*
 * Josh McGrew
 * Assignment 3: Challenge 2
 * destroy objects when they go out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;
    private HealthSystem hs;

    private void Start()
    {
        hs = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        //and take damage
        else if (transform.position.y < bottomLimit)
        {
            hs.damage();
            Destroy(gameObject);
        }

    }
}
