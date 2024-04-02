using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Transform player;
    [SerializeField] int damage = 6;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("jugador").transform;
    }

    void Update()
    {
        Vector3 directionToPlayer = Vector3.zero;

        directionToPlayer = player.position - transform.position;

        directionToPlayer = directionToPlayer.normalized;
        transform.position += directionToPlayer * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.playerHasBeenHit(1);
            print("man dao");
            Destroy(gameObject);
        }   
    }

}
//enemy