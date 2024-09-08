using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerEnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform spawnPoint;
    public int spawnCount;

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
        Instantiate(Enemy, spawnPoint.position, Quaternion.identity);
        spawnCount--;
        if (spawnCount == 0)
        {
            this.GameObject().SetActive(false);
        }
    }
}
