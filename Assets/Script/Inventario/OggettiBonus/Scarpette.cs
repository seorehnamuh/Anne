using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarpette : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        SingletonPickUp.Instance.AttivaScarpette();
    }
}