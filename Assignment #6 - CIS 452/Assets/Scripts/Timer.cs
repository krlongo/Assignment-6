/*
 * Kevon Long
 * Timer.cs
 * Assignment #6
 * Gives the player 60 seconds to play the game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timer;
    public float gameTimer = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        timer.text = gameTimer.ToString("00");
        if(gameTimer < 0.0f)
        {
            SceneManager.LoadScene("ResultsScreen");
        }
    }
}
