using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    public SingletonPickUp singlePickUp;
    public PlayerControllerFirstPerson playerControllerFirstPerson;
    public PlayerHealth playerHealth;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.V) && singlePickUp.pickedPicksUps["Scarpette"] > 0)
        {
            Debug.Log("Scarpette working");
            singlePickUp.pickedPicksUps["Scarpette"]--;
        }
        if (Input.GetKeyDown(KeyCode.H) && singlePickUp.pickedPicksUps["Legoo"] > 0)
        {
            Debug.Log("Legoo working");
        }
        if (Input.GetKeyDown(KeyCode.L) && singlePickUp.pickedPicksUps["Saponetta"] > 0)
        {
            Debug.Log("Saponetta working");
            singlePickUp.pickedPicksUps["Saponetta"]--;
        }
        if (Input.GetKeyDown(KeyCode.R) && singlePickUp.pickedPicksUps["Dolcetti"] > 0)
        {
            Debug.Log("Dolcetti working");
            playerHealth.currentHealth = 10;
            singlePickUp.pickedPicksUps["Dolcetti"]--;
        }
        //        scarpette - fanno andare piu veloce il player premendo lettera V per un tot di secondi
        //legoo - una volta equipaggiati fanno danno al boss ogni volta che si preme tasto H
        //saponetta - una volta equipaggiato(nell'inventario)   rallenta il boss se premi tasto L per un tot di secondi
        //Dolcetti - ricarica un tot della vita-sono usa e getta
    }

    
}
