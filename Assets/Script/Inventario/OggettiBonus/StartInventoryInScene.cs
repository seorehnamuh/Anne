using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartInventoryInScene : MonoBehaviour
{
    public GameObject inventoryImageScarpette;
    public TMP_Text textScarpette;

    public GameObject inventoryImageDolcetti;
    public TMP_Text textDolcetti;

    public GameObject inventoryImageSaponetta;
    public TMP_Text textSaponetta;

    public GameObject inventoryImageLego;
    public TMP_Text textLego;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("ScarpettePlayerPref")!= null)
        {
            inventoryImageScarpette.SetActive(true);
            textScarpette.text = PlayerPrefs.GetInt("ScarpettePlayerPref").ToString();

        }

        if (PlayerPrefs.GetInt("DolcettiPlayerPref") != null)
        {
            inventoryImageDolcetti.SetActive(true);
            textDolcetti.text = PlayerPrefs.GetInt("DolcettiPlayerPref").ToString();

        }

        if (PlayerPrefs.GetInt("SaponettaPlayerPref") != null)
        {
            inventoryImageSaponetta.SetActive(true);
            textSaponetta.text = PlayerPrefs.GetInt("SaponettaPlayerPref").ToString();

        }

        if (PlayerPrefs.GetInt("LegoPlayerPref") != null)
        {
            inventoryImageLego.SetActive(true);
            textLego.text = PlayerPrefs.GetInt("LegoPlayerPref").ToString();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
