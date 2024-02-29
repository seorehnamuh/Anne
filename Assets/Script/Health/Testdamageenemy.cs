using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (collision.gameObject.CompareTag("Legoo"))

        {
            _ = currentHealth - 5;
            enemyHealthBar.SetHealth(currentHealth);
            Debug.Log("Ragno colpito");
        }
    }
}
