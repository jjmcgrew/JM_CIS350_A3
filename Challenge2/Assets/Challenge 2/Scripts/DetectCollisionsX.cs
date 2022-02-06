/*
 * Josh McGrew
 * Assignment 3: Challenge 2
 * collision detection and handling
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore ds;

    private void Start()
    {
        ds = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<DisplayScore>();
    }

    //add score also
    private void OnTriggerEnter(Collider other)
    {
        ds.score++;
        Destroy(gameObject);
    }
}
