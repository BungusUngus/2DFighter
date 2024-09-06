using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float timer;
    public float resetTime;
    public float spawn;
    public float currentWave;

    // thingsIWantToMakeCollectionOf []

    // Start is called before the first frame update
    void Start()
    {
        timer = resetTime;

        currentWave = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Spawn();

            if (resetTime > 5f)
            {
                resetTime -= .1f;
            }
            timer = resetTime;
        }
    }

    void Spawn()
    {
        int randomIndex = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[randomIndex], transform.position, Quaternion.identity);
    }
}
