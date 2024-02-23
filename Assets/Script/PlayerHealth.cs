using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

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

    public void PlayerDeath()
    {
        if (currentHealth == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("restart");
        }
    }
}
