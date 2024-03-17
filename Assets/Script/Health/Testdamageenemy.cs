using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Testdamageenemy : MonoBehaviour

{

    public int currentHealth;
    public int maxHealth = 100;
    public EnemyHealth enemyHealthBar;
    void Start()
    {
        currentHealth = maxHealth;
        enemyHealthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            currentHealth -= 10;

            enemyHealthBar.SetHealth(currentHealth);
            Debug.Log($"The spider has the current health: {currentHealth}");
        }

        if (currentHealth == 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
