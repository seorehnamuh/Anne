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

  
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.U))

        {
            TakeDamage(5);
        }
    }

    void TakeDamage(int damage)
    {
        {
            currentHealth -= damage;

            enemyHealthBar.SetHealth(currentHealth);
        }
    }



}
