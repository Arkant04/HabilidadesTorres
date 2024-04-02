using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] Image healthImage;
    int maxHealth = 10;
    int currentHealth;
    int minHealth = 0;
    bool PlayerDead = true;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void PlayerHasDie()
    {
        if (currentHealth == 0)
            PlayerDead = false;

    }

    public void Heal(int healing)
    {
        currentHealth += healing;
        healthImage.fillAmount += 0.5f;
    }

    public void playerHasBeenHit(int damage)
    {
        currentHealth -= damage;
        healthImage.fillAmount -= 0.1f;
    }
 
}
