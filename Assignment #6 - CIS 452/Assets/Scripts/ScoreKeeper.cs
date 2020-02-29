/*
 * Kevon Long
 * ScoreKeeper.cs
 * Assignment #6
 * keeps and displays scores
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName == "GameScene")
        {
            score = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "You scored: " + score.ToString();
    }
}
