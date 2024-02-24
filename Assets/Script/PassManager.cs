using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Trap"))
        {
          
            SceneManager.LoadScene("BossFight");
        }
    }
}