using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2 : MonoBehaviour
{



    private void OnMouseDown()
    {
        gameObject.SetActive(false); //QUANDO CLICCHI SULL'OGG DA RACCOGLIERE LO DISATTIVI
        SingletonPickUp.Instance.AttivaSonoDue();//E CHIAMI IL PUBLIC VOID DEL SINGLETON CHE GESTISCE SIA
                                                 //LA BOOL DELL'OGGETTO, CHE CHE VENGA ATTIVATO NELL'INVENTARIO
    }
}