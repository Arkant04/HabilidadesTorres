using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] Image healthImage;
    int maxHealth = 10;
    int currentHealth;
    int minHealth = 0;
    bool PlayerDead = false;
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject gameOverScreen;
    

    void Start()
    {
       
        currentHealth = maxHealth;
        gameOverScreen.SetActive(false);
        gameOverText.SetActive(false);
    }

    void Update()
    {
       if (currentHealth <= minHealth)
        {
            gameOverScreen.SetActive(true);
            StartCoroutine(blinkingText());
            gameEvents.PlayerIsDead.Invoke();
            if(Input.GetKeyDown(KeyCode.R))
            {
                restardGame();
            }
        } 
       
       
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

    void restardGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public IEnumerator blinkingText()
    {
        while (currentHealth <= minHealth)
        {
            gameOverText.SetActive(true);
            yield return new WaitForSeconds(2f);
            
            gameOverText.SetActive(false);
            yield return new WaitForSeconds(2f);
        }
    }
}
