/*
 * Kevon Long
 * Player.cs
 * Assignment #6
 * Creates bullets and moves around
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BulletFactory bulletFactory;
    private GameObject bullet;
    public string bulletType;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletFactory = GetComponent<BulletFactory>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bulletType = "skeletonBullet";
            bullet = bulletFactory.CreateBullet(bulletType);
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bulletType = "spiderBullet";
            bullet = bulletFactory.CreateBullet(bulletType);
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            bulletType = "demonBullet";
            bullet = bulletFactory.CreateBullet(bulletType);
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        //float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0.0f, dirY);
        rb.AddForce(movement * 10f);
    }
}
