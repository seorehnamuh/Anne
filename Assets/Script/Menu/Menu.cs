using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Menu : MonoBehaviour
{
    // Called when we click the "Play" button.
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Called when we click the "Quit" button.
    public void QuitGame()
    {
        Debug.Log("You have quit the game");
        Application.Quit();
    }
}