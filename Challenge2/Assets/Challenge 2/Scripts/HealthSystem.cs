/*
 * Josh McGrew
 * Assignment 3: Challenge 2
 * manage health and game over
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public bool gameOver = false;
    public GameObject gameOverText;
    public Text hText;

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        hText.text = "Health: " + health;
        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }

    public void damage()
    {
        health--;
    }
}
