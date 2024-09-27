using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform waypoint1;
    public float speed;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoint1 == null)
        {
            waypoint1 = GameObject.FindGameObjectWithTag("Player").transform;
            return;
        }

        //To figure out the direction you can subtract two positions together
        Vector2 direction = waypoint1.position - transform.position;
        //The vector might be quite long, normalize it to make it the length of 1
        direction.Normalize();

        //We can move an object in some direction, apply some speed to it 
        direction = direction * speed * Time.deltaTime;

        //adding the direction we calculated with the current position of the UFO
        transform.position = transform.position + (Vector3)direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
