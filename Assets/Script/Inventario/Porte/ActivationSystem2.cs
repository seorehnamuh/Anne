using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationSystem2 : MonoBehaviour
{
    public GameObject oggettoDaAttivare2;
    public KeyCode inputTasto = KeyCode.Space;

    void Update()
    {
        // Verifica se il tasto di attivazione è stato premuto
        if (Input.GetKeyDown(inputTasto))
        {
            // Inverti lo stato dell'oggetto
            oggettoDaAttivare2.SetActive(!oggettoDaAttivare2.activeSelf);
            Debug.Log("Attivata");
        }
    }
}
