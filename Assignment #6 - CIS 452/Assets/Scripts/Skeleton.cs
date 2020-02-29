/*
 * Kevon Long
 * Skeleton.cs
 * Assignment #6
 * Skeleton behavior to move left and scores 100 points if hit
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Monster
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
        this.EnemyType = "Skeleton";
    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(-10.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "skeletonBullet")
        {
            ScoreKeeper.score += 100;
            Destroy(gameObject);
        }
    }
}
