using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI guiText;
    private Dictionary<string, string> objectsWithMessages;
   
    void Start()
    {
        objectsWithMessages = new Dictionary<string, string>
        {
          { "Frame", "Caspita!, è uguale a me! ma chi è lui, non è certo Bubu!" },
          { "Screen", "Che cos' e' questa cosa luminosa ?" },
          { "Holocron", "Questo gioco fa paura..." },
          { "MagicTree", "wow, è meraviglioso questo albero..." },
          { "Horse", "Ahahah, il mio è più bello, è rosso!" },
          { "Lego", "sembrano proprio le mie costuzioni!" },

        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        string gameObjectTag = other.gameObject.tag;
        if (objectsWithMessages.ContainsKey(gameObjectTag))
        {
            StartCoroutine(ShowMessage(gameObjectTag, 2));
        }

    }

    IEnumerator ShowMessage(string gameObjectTag, float delay)
    {
            string message = objectsWithMessages[gameObjectTag];
            guiText.text = message;
            guiText.enabled = true;
            yield return new WaitForSeconds(delay);
            guiText.enabled = false;
        
    }
}
