using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUI;
    private bool isPaused = false;

    void Update()
    {
        // Verifica se il tasto Esc è stato premuto
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Se il gioco è già in pausa, esci dal menu di pausa
            if (isPaused)
            {
                Resume();
            }
            else // Altrimenti, metti in pausa il gioco
            {
                Pause();
            }
        }
    }

    // Metodo per mettere in pausa il gioco
    void Pause()
    {
        // Attiva il menu di pausa
        pauseMenuUI.SetActive(true);

        // Blocca il tempo nel gioco
        Time.timeScale = 0f;

        // Imposta lo stato di pausa
        isPaused = true;
        Debug.Log("Pausa");
    }


    // Metodo per riprendere il gioco
    public void Resume()
    {
        // Disattiva il menu di pausa
        pauseMenuUI.SetActive(false);

        // Riprendi il tempo nel gioco
        Time.timeScale = 1f;

        // Imposta lo stato di pausa
        isPaused = false;
        Debug.Log("Resume");
    }

    // Metodo per uscire dall'applicazione
    public void QuitGame()
    {
        // Esci dall'applicazione
        Application.Quit();
        Debug.Log("Quit");
    }
}