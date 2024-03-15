using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddToInventory : MonoBehaviour
{
    public GameObject ImageOnInventaryCanvas;
    public string nameOfPlayerPref;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
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
            if(ImageOnInventaryCanvas!=null)
            ImageOnInventaryCanvas.SetActive(true);
            
            PlayerPrefs.SetInt(nameOfPlayerPref, PlayerPrefs.GetInt(nameOfPlayerPref)+1);

            this.gameObject.SetActive(false);
        }
    }
}
