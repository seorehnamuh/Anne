using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp4 : MonoBehaviour
{

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        SingletonPickUp.Instance.AttivaSonoQuattro();

    }
}