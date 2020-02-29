/*
 * Kevon Long
 * MonsterSpawner.cs
 * Assignment #6
 * Spawns the monsters
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    public MonsterFactory factory;

    private GameObject enemy;
    public string type;
    public float firerate = 1.0f;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && Time.time > nextFire)
        {
            nextFire = Time.time + firerate;
            type = "Demon";
            enemy = factory.CreateEnemy(type);
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && Time.time > nextFire)
        {
            nextFire = Time.time + firerate;
            type = "Spider";
            enemy = factory.CreateEnemy(type);
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && Time.time > nextFire)
        {
            nextFire = Time.time + firerate;
            type = "Skeleton";
            enemy = factory.CreateEnemy(type);
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
