using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationSystem : MonoBehaviour
{
    public GameObject oggettoDaAttivareDisattivare;
    public KeyCode inputTastoAttivazione = KeyCode.Space;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Update()
    {
        // Verifica se il tasto di attivazione è stato premuto
        if (Input.GetKeyDown(inputTastoAttivazione))
        {
            // Inverti lo stato dell'oggetto
            oggettoDaAttivareDisattivare.SetActive(!oggettoDaAttivareDisattivare.activeSelf);
            audioSource.Play();
            Debug.Log("Attivata");
        }
    }
}
