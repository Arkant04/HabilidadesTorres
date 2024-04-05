using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Transform player;
    bool PlayerDead = false;
    [SerializeField] int damage = 6;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("jugador").transform;
        gameEvents.PlayerIsDead.AddListener(PlayerHasDie);
    }

    void Update()
    {
        Vector3 directionToPlayer = Vector3.zero;

        directionToPlayer = player.position - transform.position;

        directionToPlayer = directionToPlayer.normalized;
        if (PlayerDead)
            transform.position -= directionToPlayer * speed * Time.deltaTime;

        else
        transform.position += directionToPlayer * speed * Time.deltaTime;
    }

    void PlayerHasDie()
    {
        PlayerDead = true;
        Destroy(gameObject);
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