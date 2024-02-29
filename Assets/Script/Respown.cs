using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respown : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Respown"))
        {

            SceneManager.LoadScene("restart");
        }
    }
}
