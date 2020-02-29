/*
 * Kevon Long
 * BulletFactory.cs
 * Assignment #6
 * Determines which bullet to fire
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject DemonBullet;
    public GameObject SkeletonBullet;
    public GameObject SpiderBullet;

    private GameObject bulletToSpawn;

    public GameObject CreateBullet(string bulletType)
    {
        Debug.Log("Creating " + bulletType);
        bulletToSpawn = null;

        if (bulletType.Equals("demonBullet"))
        {
            bulletToSpawn = DemonBullet;
        }
        else if (bulletType.Equals("skeletonBullet"))
        {
            bulletToSpawn = SkeletonBullet;
        }
        else if (bulletType.Equals("spiderBullet"))
        {
            bulletToSpawn = SpiderBullet;
            
        }
        return bulletToSpawn;
    }
}
