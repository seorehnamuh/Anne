using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;
    public PlayerControllerFirstPerson playerController;
    //[SerializeField] Canvas canvas;
    public float delayBeforeSceneChange = 2f; // Ritardo prima del cambio scena
    public float fadeDuration = 1f; // Durata del fade-out
    public Image fadePanel; // Il pannello UI per il fade-out

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //canvas.enabled = false;
        // Assicurati che il pannello di fade-out sia completamente trasparente all'avvio
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 0f);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            PlayerDeath();
        }
    }

    IEnumerator DelayedSceneChange(string sceneName)
    {
        // Blocca l'input del giocatore
        playerController.enabled = false;
        Cursor.lockState = CursorLockMode.None;

        // Fade-out
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1f);

        // Attendi per il ritardo specificato
        yield return new WaitForSeconds(delayBeforeSceneChange);

        // Carica la nuova scena
        SceneManager.LoadScene(sceneName);
    }

    public void PlayerDeath()
    {
        // Attiva la coroutine per il cambio scena ritardato
        StartCoroutine(DelayedSceneChange("restart"));
    }
}