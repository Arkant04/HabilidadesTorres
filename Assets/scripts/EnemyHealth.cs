using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    int maxHealth = 10;
    int currentHealth;
    int minHealth = 0;
    int damage = 6;

    void Start()
    {
        currentHealth = maxHealth;
        
    }

    void Update()
    {
        print(currentHealth);    
    }
    public void enemyHasBeenHit(int amount)
    {
        
        currentHealth -= amount;
        if (currentHealth <= minHealth) 
        {
          Destroy(Enemy);
          //enemyspawn.spawner1();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BigDamege"))
        {
            enemyHasBeenHit(10);
            print("Gran impacto");
        }


        else if (collision.gameObject.CompareTag("MediumDamage"))
        {
            enemyHasBeenHit(5);
            print("impacto normal");
        }

        else if (collision.gameObject.CompareTag("LittleDamage"))
        {
            enemyHasBeenHit(3);
            print("impacto minusculo");

        }
    }

    /*EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
    enemyHealth.enemyHasBeenHit(6);*/

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("bullet"))
    //    {
    //        enemyHasBeenHit(damage);
    //        print("te di");

    //    }
    //}


}
