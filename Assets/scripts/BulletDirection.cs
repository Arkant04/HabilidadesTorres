using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    
    void Start()
    {

    }

    public void bulletShoot(Vector3 directionToMouse, float speed)
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>(); 
        rb.velocity = directionToMouse * speed;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {
            EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.enemyHasBeenHit(6);
            print("te di");

        }
    }*/
}
