using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PORTA2 : MonoBehaviour
{
    private void OnMouseDown()
    {

        if (SingletonPickUp.Instance.obj2IsActive)
        {
            gameObject.SetActive(false);
            SingletonPickUp.Instance.obj2IsActive = false;
            SingletonPickUp.Instance.SonoDue.SetActive(false);
        }


    }
}
