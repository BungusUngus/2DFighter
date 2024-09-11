using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerEnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform spawnPoint;
    public int spawnCount;
    public float spawnRate;
    private float _spawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _spawnTime = Time.time + spawnRate;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ( Time.time - _spawnTime > spawnRate)
        { 
            Instantiate(Enemy, spawnPoint.position, Quaternion.identity);
            _spawnTime = Time.time;
            spawnCount--;
            if (spawnCount == 0)
            {
                this.GameObject().SetActive(false);
            }
        }
    }
}
