﻿/*
 * Kevon Long
 * SceneChanger.cs
 * Assignment #6
 * changes scenes
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GameScene");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
