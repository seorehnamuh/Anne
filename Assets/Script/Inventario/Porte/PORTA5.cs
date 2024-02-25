using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PORTA5 : MonoBehaviour
{
    private void OnMouseDown()
    {

        if (SingletonPickUp.Instance.obj5IsActive)
        {
            gameObject.SetActive(false);
            SingletonPickUp.Instance.obj5IsActive = false;
            SingletonPickUp.Instance.SonoCinque.SetActive(false);
        }


    }
}
