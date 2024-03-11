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
    
    public float delayBeforeSceneChange = 2f; 
    public float fadeDuration = 1f; 
    public Image fadePanel; 

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
       
        
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 0f);
    }
    void Update()
    {
        healthBar.SetHealth(currentHealth);
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
    
        playerController.enabled = false;
        Cursor.lockState = CursorLockMode.None;

       
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1f);

     
        yield return new WaitForSeconds(delayBeforeSceneChange);

      
        SceneManager.LoadScene(sceneName);
    }

    public void PlayerDeath()
    {
        PlayerPrefs.DeleteAll();
        StartCoroutine(DelayedSceneChange("restart"));
    }
}