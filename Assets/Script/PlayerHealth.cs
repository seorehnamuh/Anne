using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;
    public PlayerControllerFirstPerson playerController;
    [SerializeField] Canvas canvas;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        canvas.enabled = false;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void playerIsDead()
    {
        canvas.enabled = true;
        playerController.enabled = false;
    }
}
