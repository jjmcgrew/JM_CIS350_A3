/*
 * Josh McGrew
 * Assignment 3: Prototype 2
 * player to shoot prefab (food)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, prefab.transform.rotation);
        }
    }
}
