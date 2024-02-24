using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public float fadeDuration = 1f; // Durata del fade-out
    public Image fadePanel; // Il pannello UI per il fade-out
    public PlayerHealth playerHealth;
    void Start()
    {
        // Assicurati che il pannello di fade-out sia completamente trasparente all'avvio
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 0f);

        // Avvia il fade-out
    }

    public void Update()
    {
        if (playerHealth.currentHealth == 0)
        {
            StartFadeOut();
        }
    }
    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1f);
    }
}