/*
 * Josh McGrew
 * Assignment 3: Challenge 2
 * display score script
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text t;
    public int score = 0;
    public HealthSystem hs;

    private void Start()
    {
        t = GetComponent<Text>();
        t.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Score: " + score;
        if (score >= 5)
        {
            //borrow game over from HealthSystem
            hs.gameOver = true;
            hs.gameOverText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
