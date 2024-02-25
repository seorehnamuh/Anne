using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup3 : MonoBehaviour
{

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        SingletonPickUp.Instance.AttivaSonoTre();
                                                 
    }
}