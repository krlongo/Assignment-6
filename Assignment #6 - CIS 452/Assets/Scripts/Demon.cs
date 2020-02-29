/*
 * Kevon Long
 * Demon.cs
 * Assignment #6
 * Demon behavior to move left and scores 100 points if hit
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : Monster
{
    float moveSpeed = 7f;
    

    //Player target;
    Vector2 moveDirection;
    //float dirX, dirY;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.EnemyType = "Demon";
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-10.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "demonBullet")
        {
            ScoreKeeper.score += 100;
            Destroy(gameObject);
        }
    }
}
