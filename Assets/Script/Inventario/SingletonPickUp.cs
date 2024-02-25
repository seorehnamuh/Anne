using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPickUp : MonoBehaviour
{
    public GameObject SonoUno;
    public GameObject SonoDue;
    public GameObject SonoTre;
    public GameObject SonoQuattro;
    public GameObject SonoCinque;
    public GameObject SonoSei;
    public bool obj1IsActive = false;
    public bool obj2IsActive = false;
    public bool obj3IsActive = false;
    public bool obj4IsActive = false;
    public bool obj5IsActive = false;
    public bool obj6IsActive = false;

    public static SingletonPickUp Instance;
    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        SonoUno.SetActive(false);
        obj1IsActive = false;

        SonoUno.SetActive(false);
        obj2IsActive = false;

        SonoTre.SetActive(false);
        obj3IsActive = false;

        SonoQuattro.SetActive(false);
        obj4IsActive = false;

        SonoCinque.SetActive(false);
        obj5IsActive = false;

        SonoSei.SetActive(false);
        obj6IsActive = false;
    }

    public void AttivaSonoUno()
    {
        SonoUno.SetActive(true);
        obj1IsActive = true;
    }

    public void AttivaSonoDue()
    {
        SonoDue.SetActive(true);
        obj2IsActive = true;
    }

    public void AttivaSonoTre()
    {
        SonoTre.SetActive(true);
        obj3IsActive = true;
    }

    public void AttivaSonoQuattro()
    {
        SonoQuattro.SetActive(true);
        obj4IsActive = true;
    }

    public void AttivaSonoCinque()
    {
        SonoCinque.SetActive(true);
        obj5IsActive = true;
    }

    public void AttivaSonoSei()
    {
        SonoSei.SetActive(true);
        obj6IsActive = true;
    }

}
