using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPickUp : MonoBehaviour
{
    public Dictionary<string, int> pickedPicksUps;

    void Start()
    {
        pickedPicksUps = new Dictionary<string, int>
        {
            { "Saponetta", 0 },
            { "Legoo", 0 },
            { "Dolcetti", 0 },
            { "Scarpette", 0 }
        };
    }
    private void OnTriggerEnter(Collider other)
    {
        if (pickedPicksUps.ContainsKey(other.gameObject.tag))
        {
            string pickedUpTag = other.gameObject.tag;
            pickedPicksUps[pickedUpTag] += 1;
            Debug.Log($"{other.gameObject.tag} {pickedPicksUps[pickedUpTag]}");
            Destroy(other.gameObject);
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //Debug.Log("Collision");
    //    //Debug.Log(collision.gameObject.tag);
    //    //if (pickedPicksUps.ContainsKey(collision.gameObject.tag))
    //    //{
    //    //    Debug.Log("Dic contains the tag");
    //    //}
    //    //foreach(string pickedUpTag in pickedPicksUps.Keys)
    //    //{
    //    //    if (collision.gameObject.tag == pickedUpTag)
    //    //    {
    //    //        pickedPicksUps[pickedUpTag] = true;
    //    //        Destroy(collision.gameObject);
    //    //    }
    //    //}
    //    //foreach (string pickedUpTag in pickedPicksUps.Keys)
    //    //{
    //    //    if (pickedPicksUps[pickedUpTag] == true)
    //    //    {
    //    //        Debug.Log($"{pickedUpTag} {pickedPicksUps[pickedUpTag]}");
    //    //    }
    //    //}
    //}
    //public GameObject SonoUno;
    //public GameObject SonoDue;
    //public GameObject SonoTre;
    //public GameObject SonoQuattro;
    //public GameObject SonoCinque;
    //public GameObject SonoSei;

    //public GameObject Saponetta;
    //public GameObject Legoo;
    //public GameObject Dolcetti;
    //public GameObject Scarpette;
    //public bool obj1IsActive = false;
    //public bool obj2IsActive = false;
    //public bool obj3IsActive = false;
    //public bool obj4IsActive = false;
    //public bool obj5IsActive = false;
    //public bool obj6IsActive = false;

    //public bool obj7IsActive = false;
    //public bool obj8IsActive = false;
    //public bool obj9IsActive = false;
    //public bool obj10IsActive = false;


    //public static SingletonPickUp Instance;
    //private void Awake()
    //{

    //    if (Instance != null && Instance != this)
    //    {
    //        Destroy(this);
    //    }
    //    else
    //    {
    //        Instance = this;
    //    }
    //}

    //void Start()
    //{
    //    SonoUno.SetActive(false);
    //    obj1IsActive = false;

    //    SonoUno.SetActive(false);
    //    obj2IsActive = false;

    //    SonoTre.SetActive(false);
    //    obj3IsActive = false;

    //    SonoQuattro.SetActive(false);
    //    obj4IsActive = false;

    //    SonoCinque.SetActive(false);
    //    obj5IsActive = false;

    //    SonoSei.SetActive(false);
    //    obj6IsActive = false;

    //    Saponetta.SetActive(false);
    //    obj7IsActive = false;

    //    Legoo.SetActive(false);
    //    obj8IsActive = false;

    //    Dolcetti.SetActive(false);
    //    obj9IsActive = false;

    //    Scarpette.SetActive(false);
    //    obj10IsActive = false;
    //}

    //public void AttivaSonoUno()
    //{
    //    SonoUno.SetActive(true);
    //    obj1IsActive = true;
    //}

    //public void AttivaSonoDue()
    //{
    //    SonoDue.SetActive(true);
    //    obj2IsActive = true;
    //}

    //public void AttivaSonoTre()
    //{
    //    SonoTre.SetActive(true);
    //    obj3IsActive = true;
    //}

    //public void AttivaSonoQuattro()
    //{
    //    SonoQuattro.SetActive(true);
    //    obj4IsActive = true;
    //}

    //public void AttivaSonoCinque()
    //{
    //    SonoCinque.SetActive(true);
    //    obj5IsActive = true;
    //}

    //public void AttivaSonoSei()
    //{
    //    SonoSei.SetActive(true);
    //    obj6IsActive = true;
    //}

    //public void AttivaSaponetta()
    //{
    //    Saponetta.SetActive(true);
    //    obj7IsActive = true;
    //}

    //public void AttivaLegoo()
    //{
    //    Legoo.SetActive(true);
    //    obj8IsActive = true;
    //}

    //public void AttivaDolcetti()
    //{
    //    Dolcetti.SetActive(true);
    //    obj9IsActive = true;
    //}

    //public void AttivaScarpette()
    //{
    //    Scarpette.SetActive(true);
    //    obj10IsActive = true;
    //}

}
