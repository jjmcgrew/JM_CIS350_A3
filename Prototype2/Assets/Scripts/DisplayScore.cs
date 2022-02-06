﻿/*
 * Josh McGrew
 * Assignment 3: Prototype 2
 * display score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textBox;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set text component reference on start
        textBox = GetComponent<Text>();

        textBox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + score;
    }
}
