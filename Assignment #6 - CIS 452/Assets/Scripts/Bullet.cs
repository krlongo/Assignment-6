/*
 * Kevon Long
 * Bullet.cs
 * Assignment #6
 * Destroys the bullet when it spawns 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float selfDestructTimer = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        selfDestructTimer -= Time.deltaTime;
        if(selfDestructTimer < 0.0f)
        {
            Destroy(gameObject);
        }
    }

}
