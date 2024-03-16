using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AddToInventory : MonoBehaviour
{
    public GameObject ImageOnInventaryCanvas;
    public string nameOfPlayerPref;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        Debug.Log("Current Scene Name: " + currentSceneName);
        if (currentSceneName != "BossFight")
        {
            PlayerPrefs.DeleteAll();
        }
        text.text = PlayerPrefs.GetInt(nameOfPlayerPref).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PlayerPrefs.GetInt(nameOfPlayerPref).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //if (ImageOnInventaryCanvas != null)
            //    ImageOnInventaryCanvas.SetActive(true);

            PlayerPrefs.SetInt(nameOfPlayerPref, PlayerPrefs.GetInt(nameOfPlayerPref)+1);

            this.gameObject.SetActive(false);
        }
    }
}
